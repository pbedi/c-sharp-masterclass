using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Events_and_Delegates
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("NotificationService: notifying: {0} download is done...", e.file.Title);
        }
    }
}
