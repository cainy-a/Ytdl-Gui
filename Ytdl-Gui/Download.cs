using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Ytdl_Gui
{
	public static class Download
	{
		public static void DownloadUrls(List<string> urls, bool extractAudio = false, bool forceRedownload = false)
		{
			var ytdlDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Cain Atkinson\\Ytdl-Gui");
			var ytdlPath = Path.Combine(ytdlDir, "youtube-dl.exe");
			if (!File.Exists(ytdlPath) || forceRedownload)
			{
				Directory.CreateDirectory(ytdlDir);
				GetDownloader(ytdlPath);
			}

		foreach (var VARIABLE in urls)
			{
				RunYtdl(VARIABLE, ytdlPath, extractAudio);
			} // Download each URL
			File.Delete("youtube-dl.exe"); // Delete the Downloader
		}
		private static void RunYtdl(string url, string ytdlPath, bool extractAudio = false)
		{
			var dlProcess = Process.Start(ytdlPath,
										  extractAudio ? $"-x {url}" : url); // Start the Process
			dlProcess.WaitForExit(); // Wait for the Downloader to finish
		} // Calls YTDL and waits for it
		private static void GetDownloader(string pathToDownload)
		{
			using (var client = new WebClient())
			{
				
				client.DownloadFile("https://yt-dl.org/downloads/latest/youtube-dl.exe", pathToDownload);
			}
		} // Downloads Youtube-DL
	}
}