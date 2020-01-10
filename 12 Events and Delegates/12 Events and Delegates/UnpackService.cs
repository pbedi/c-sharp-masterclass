using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Events_and_Delegates
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("UnpackerService: Unpacking the file: {0}...", e.file.Title);
        }
    }
}
