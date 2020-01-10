using System;
using System.Threading;

namespace _12_Events_and_Delegates
{
    public class DownloadHelper
    {
        //step 1 - create a delegate by coder 
        // public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);

        //step 2 - create an event based on a delegate 
        //public event FileDownloadedEventHandler FileDownloaded;

        // or using C#'s EventHandler
        public event EventHandler<FileEventArgs> FileDownloaded;

        //step 3 - raise the event
        protected virtual void OnFileDownoaded(File file)
        {
            if(FileDownloaded != null)
            {
                FileDownloaded(this, new FileEventArgs(){ file = file});
            }
        }

        public void Download(File file)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);
            //step 3.1
            OnFileDownoaded(file);
        }
    }
}
