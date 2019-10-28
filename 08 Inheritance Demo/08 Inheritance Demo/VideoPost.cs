using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _08_Inheritance_Demo
{
    class VideoPost: Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;

        // properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost()
        {

        }

        public VideoPost(string title, bool isPublic, string sendByUsername, string videoURL, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by - {2}, watch video - {3} - run time {4} seconds", this.ID, this.Title, this.SendByUsername, this.VideoURL, this.Length);
        }

        public void Play()
        {
            if(!isPlaying)
            {
                Console.WriteLine("Playing Video {0}", this.Title);
                //SetTimeout
                timer = new Timer(TimerCallback, null, 0, 1000);
                this.isPlaying = true;
            }
            
        }

        private void TimerCallback(Object o)
        {
            if(currentDuration < this.Length)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}s", this.currentDuration);
                GC.Collect();
            } else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(this.isPlaying)
            {
                Console.WriteLine("Video Stopped {0}s", this.currentDuration);
                this.currentDuration = 0;
                this.isPlaying = false;
                timer.Dispose();
            }
            
        }
    }
}
