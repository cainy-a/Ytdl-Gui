using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Ytdl_Gui
{
	public static class Download
	{
		public static void DownloadUrls(List<string> urls)
		{
			GetDownloader();
			foreach (var VARIABLE in urls)
			{
				RunYtdl(VARIABLE);
			} // Download each URL
			File.Delete("youtube-dl.exe"); // Delete the Downloader
		}
		private static void RunYtdl(string url)
		{
			var dlProcess = Process.Start(
				Directory.GetCurrentDirectory() + "\\youtube-dl",
				url); // Start the Process
			dlProcess.WaitForExit(); // Wait for the Downloader to finish
		} // Calls YTDL and waits for it
		private static void GetDownloader()
		{
			using (var client = new WebClient())
			{
				client.DownloadFile("https://yt-dl.org/downloads/2020.05.08/youtube-dl.exe", "youtube-dl.exe");
			}
		} // Downloads Youtube-DL
	}
}