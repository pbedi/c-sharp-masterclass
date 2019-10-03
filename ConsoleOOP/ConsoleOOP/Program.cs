using System;

namespace ConsoleOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Human phil = new Human();
            phil.lastName = "Bedi";
            phil.IntroduceMyself();
            Human birdi = new Human();
            birdi.lastName = "Birdi";
            birdi.IntroduceMyself();*/

            Human1 pb = new Human1("Philip", "Bedi", "Brown", 58);
            pb.IntroduceMyself();

             Box box = new Box();
            box.length = 3;
            box.height = 5;
            box.width = 4;
            box.DisplayInfo();

            Members member = new Members();
            member.Introducing(true);
        }
    }
}
