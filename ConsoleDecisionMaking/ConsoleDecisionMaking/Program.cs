using System;

namespace ConsoleDecisionMaking
{
    class Program
    {


        static int highscore = 300;
        static string highscorePlayer = "Philip";

        static void Main(string[] args)
        {
            CheckHighscore(200, "David");
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party");
                    break;
                case 25:
                    Console.WriteLine("You can party. Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you?");
                    break;
            }
            // normal if else
            CheckStateOfMatter(-5);
            CheckStateOfMatter(80);
            CheckStateOfMatter(110);
            // Ternary Operator
            CheckStateOfMatterUsingTernary(-5);
            CheckStateOfMatterUsingTernary(80);
            CheckStateOfMatterUsingTernary(110);

        }
        public static void CheckStateOfMatter(int temp)
        {
            string stateOfMatter;

            if (temp < 0)
                stateOfMatter = "Solid";
            else if (temp > 100)
                stateOfMatter = "Gas";
            else
                stateOfMatter = "Liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
        }

        public static void CheckStateOfMatterUsingTernary(int temp)
        {
            string stateOfMatter = temp < 0 ? "Solid" : temp > 100 ? "Gas" : "Liquid";
            Console.WriteLine("State of matter by Ternary is {0}", stateOfMatter);

        }
        public static void CheckHighscore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            } else
            {
                Console.WriteLine("The highscore could not be broken, it is still " + highscore);
                Console.WriteLine("It is still held by " + highscorePlayer);
            }
        }
        
       
    }
}
