using System;

namespace _12_Events_and_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            var file = new File() { Title = "File 1" };
            var downloader = new DownloadHelper(); // publisher
            var unpackService = new UnpackService(); // receiver
            downloader.FileDownloaded += unpackService.OnFileDownloaded;

            var notificationService = new NotificationService(); // receiver 2
            downloader.FileDownloaded += notificationService.OnFileDownloaded;

            downloader.Download(file);
        }
    }
}
