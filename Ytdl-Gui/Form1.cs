using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ytdl_Gui.Download;

namespace Ytdl_Gui
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			if (!VistaSecurity.IsAdmin())
			{
				VistaSecurity.AddShieldToButton(buttonDownload); // Add a shield to Download Button
				buttonDownload.Text = "Get admin (REQUIRED)";
			}
		}

		public static string SavePath;
		public static List<string> Urls = new List<string>();
		public static bool Busy = false;

		private void Form1_Load(object sender, EventArgs e)
		{
			SavePath = System.IO.Directory.GetCurrentDirectory(); // Default Save Path to current directory
			textBoxPath.Text = SavePath; // Update Display

			if (!VistaSecurity.IsAdmin())
				VistaSecurity.RestartElevated(); // Restart as admin if needed
		}

		private void linkLabelYTDL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabelYTDL.LinkVisited = true;
			Process.Start("https://youtube-dl.org");
		} // Show youtube-dl website on click

		private void linkLabelCain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabelCain.LinkVisited = true;
			Process.Start("https://github.com/cainy-a");
		} // Show my github page on click

		private void buttonClear_Click(object sender, EventArgs e)
		{
			listBoxSelected.Items.Clear();
			Urls.Clear();
		}

		private void linkLabelSites_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabelSites.LinkVisited = true;
			Process.Start("http://ytdl-org.github.io/youtube-dl/supportedsites.html");
		} // Show site containing a list of supported sites on click

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			Urls.Add(textBoxAdd.Text); // Add to local list
			listBoxSelected.Items.Clear(); // Clear Displayed list
			listBoxSelected.Items
				.AddRange(Urls
					.ToArray()); // Add local list into empty displayed list. This approach makes sure that they are always in sync.
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = SavePath; // Make Folder Browser use current path as Root
			folderBrowserDialog1.ShowDialog(); // Show the Dialog
			SavePath = folderBrowserDialog1.SelectedPath; // Save the Folder Path
			textBoxPath.Text = SavePath; // Update Display
		}

		private async void buttonDownload_Click(object sender, EventArgs e)
		{
			if (Busy)
			{
				buttonDownload.Text = "I'm busy, Please Wait.";
				MessageBox.Show("I'm busy!",
					"I'm busy right now, please wait until the button changes to say \"done\".",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			System.IO.Directory.SetCurrentDirectory(SavePath);
			List<string> tempUrls = new List<string>();
			if (VistaSecurity.IsAdmin())
			{
				Busy = true;
				buttonDownload.Text = "Downloading... Please wait";

				foreach (var VARIABLE in listBoxSelected.Items)
				{
					tempUrls.Add(VARIABLE.ToString());
				} // Hacky code to try and work around the WinForms collection

				// DownloadUrls(tempUrls); // old way, runs it synchronously
				await Task.Factory.StartNew(() => DownloadUrls(tempUrls)); // New way, should run async.

				buttonDownload.Text = "Done!";
				Busy = false;
			}
			else
			{
				buttonDownload.Text = "Getting admin";
				VistaSecurity.RestartElevated(); // Restart as admin if needed
				buttonDownload.Text = "Get admin (REQUIRED)";
			}
		}

		private void textBoxPath_TextChanged(object sender, EventArgs e)
			=> SavePath = textBoxPath.Text;
	}
}