using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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

			if (VistaSecurity.IsAdmin()) return;
			VistaSecurity.AddShieldToButton(buttonDownload); // Add a shield to Download Button
			buttonDownload.Text = "Get admin (REQUIRED)";
		}

		private static string _savePath;
		private static List<string> _urls = new List<string>();
		private static bool _busy;

		private void Form1_Load(object sender, EventArgs e)
		{
			_savePath = Directory.GetCurrentDirectory(); // Default Save Path to current directory
			textBoxPath.Text = _savePath; // Update Display

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
			_urls.Clear();
		}

		private void linkLabelSites_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabelSites.LinkVisited = true;
			Process.Start("http://ytdl-org.github.io/youtube-dl/supportedsites.html");
		} // Show site containing a list of supported sites on click

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			_urls.Add(textBoxAdd.Text); // Add to local list
			listBoxSelected.Items.Clear(); // Clear Displayed list
			listBoxSelected.Items
				.AddRange(_urls
					.ToArray()); // Add local list into empty displayed list. This approach makes sure that they are always in sync.
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			if (_busy) return;
			folderBrowserDialog1.SelectedPath = _savePath; // Make Folder Browser use current path as Root
			folderBrowserDialog1.ShowDialog(); // Show the Dialog
			_savePath = folderBrowserDialog1.SelectedPath; // Save the Folder Path
			textBoxPath.Text = _savePath; // Update Display
		}

		private async void buttonDownload_Click(object sender, EventArgs e)
		{
			if (_busy)
			{
				buttonDownload.Text = "I'm busy, Please Wait.";
				MessageBox.Show("I'm busy right now, please wait until the button changes to say \"done\".",
					"I'm busy!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			Directory.SetCurrentDirectory(_savePath);
			var tempUrls = new List<string>();
			if (VistaSecurity.IsAdmin())
			{
				_busy = true;
				buttonDownload.Text = "Downloading... Please wait";

				tempUrls.AddRange(from object variable in listBoxSelected.Items select variable.ToString());

				// DownloadUrls(tempUrls); // old way, runs it synchronously
				await Task.Factory.StartNew(() => DownloadUrls(tempUrls, checkBoxExtract.Checked, checkBoxRedownload.Checked));

				buttonDownload.Text = "Done!";
				_busy = false;
			}
			else
			{
				buttonDownload.Text = "Getting admin";
				VistaSecurity.RestartElevated(); // Restart as admin if needed
				buttonDownload.Text = "Get admin (REQUIRED)";
			}
		}

		private void textBoxPath_TextChanged(object sender, EventArgs e)
		{
			if (_busy) return;
			_savePath = textBoxPath.Text;
		}
	}
}