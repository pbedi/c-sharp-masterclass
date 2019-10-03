using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video video { get; set; }
    }
    public class VideoEncoder
    {
        // specfic to create
        //public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);
        //public event VideoEncoderEventHandler VideoEncoded;

        //using in built 
        public event EventHandler<VideoEventArgs> VideoEncoded;


        public void Encode( Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { video = video });
            }
        }
    }
}
