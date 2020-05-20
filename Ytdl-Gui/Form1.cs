using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ytdl_Gui
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public static string SavePath;
		private void Form1_Load(object sender, EventArgs e)
		{
			SavePath = System.IO.Directory.GetCurrentDirectory(); // Default Save Path to current directory
			textBoxPath.Text = SavePath; // Update Display
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
			throw new System.NotImplementedException();
		}

		private void linkLabelSites_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabelSites.LinkVisited = true;
			Process.Start("http://ytdl-org.github.io/youtube-dl/supportedsites.html");
		} // Show site containing a list of supported sites on click

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			throw new System.NotImplementedException();
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = SavePath;
			folderBrowserDialog1.ShowDialog();
			SavePath = folderBrowserDialog1.SelectedPath;
			textBoxPath.Text = SavePath;
		}

		private void buttonDownload_Click(object sender, EventArgs e)
		{
			throw new System.NotImplementedException();
		}

		private void textBoxPath_TextChanged(object sender, EventArgs e)
		{
			SavePath = textBoxPath.Text;
		}
	}
}