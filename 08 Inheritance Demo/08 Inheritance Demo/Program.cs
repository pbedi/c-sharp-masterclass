using System;

namespace _08_Inheritance_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Philip Bedi");
            
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", true, "Philip Bedi", "htpps://images.com/shows/01.jpg");

            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("A Cricket match", true, "Philip Bedi", "htpps://videos.com/shows/01.mp4", 20);

            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
            videoPost1.Stop();
        }
    }
}
