using System;

namespace _07_Array_Tic_Tac_Toe
{
    class Program
    {
        static char[,] playField =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };
        
        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int input = 0;
            bool inputCorrect = true;
            bool exitGame = true;

            Console.WriteLine("Tic Tac Toe!");
            Console.WriteLine("");
            //SetField();

            do
            {
                
                if (player == 2)
                {
                    EnterXorO('O', input);
                    player = 1;
                } else
                {
                    EnterXorO('X', input);
                    player = 2;
                }
                SetField();
                #region
                //Check winning condition
                char[] playerChars = { 'X', 'O' };
                foreach(char playerChar in playerChars)
                {
                    if(
                        (playField[0,0] == playerChar && playField[0, 1] == playerChar && playField[0, 2] == playerChar) ||
                        (playField[1, 0] == playerChar && playField[1, 1] == playerChar && playField[1, 2] == playerChar) ||
                        (playField[2, 0] == playerChar && playField[2, 1] == playerChar && playField[2, 2] == playerChar) ||
                        (playField[0, 0] == playerChar && playField[1, 0] == playerChar && playField[2, 0] == playerChar) ||
                        (playField[0, 1] == playerChar && playField[1, 1] == playerChar && playField[2, 1] == playerChar) ||
                        (playField[0, 2] == playerChar && playField[1, 2] == playerChar && playField[2, 2] == playerChar) ||
                        (playField[0, 0] == playerChar && playField[1, 1] == playerChar && playField[2, 2] == playerChar) ||
                        (playField[0, 2] == playerChar && playField[1, 1] == playerChar && playField[2, 0] == playerChar) 
                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("Player 1 is a winner ");
                        }
                        
                        else
                        {
                            Console.WriteLine("Player 2 has won!");
                        }
                            
                        Console.WriteLine("End of the game!\n Please press any key to reset the game!");
                        Console.ReadKey();
                        //reset the field
                        ResetGame();
                        break;
                    } else if (turns == 10)
                    {
                        Console.WriteLine("Its a Draw!");
                        Console.WriteLine("End of the game!\n Please press any key to reset the game!");
                        Console.ReadKey();
                        //reset the field
                        ResetGame();
                        break;
                    } else
                    {
                        Console.WriteLine("Else condition, no of turns {0}", turns);
                    }
                }

                #endregion

                #region
                // Test if field is already taken
                do
                {
                    Console.Write("\nPlayer {0}: Choose your field!", player);
                    try
                    {
                        string input1 = Console.ReadLine();

                        if( input1 == " ")
                        {
                            Console.WriteLine("Good bye!!");
                            exitGame = false;
                            break;
                        } else
                        {
                            input = Convert.ToInt32(input1);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                        Console.ReadKey();
                    }
                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect Input! Please pick another field!");
                        inputCorrect = false;
                    }


                } while (!inputCorrect);
                #endregion

            } while (exitGame);

            
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("");
            //Console.WriteLine("    |    |    ");
            Console.WriteLine("____|____|____");
            Console.WriteLine("  {0} |  {1} |  {2}", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine("  {0} |  {1} |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine("  {0} |  {1} |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine("Choose a number (Space and enter to quit)");
            turns++;
        }

        public static void EnterXorO(char playerChar, int input)
        {
            switch (input)
            {
                case 1: playField[0, 0] = playerChar; break;
                case 2: playField[0, 1] = playerChar; break;
                case 3: playField[0, 2] = playerChar; break;
                case 4: playField[1, 0] = playerChar; break;
                case 5: playField[1, 1] = playerChar; break;
                case 6: playField[1, 2] = playerChar; break;
                case 7: playField[2, 0] = playerChar; break;
                case 8: playField[2, 1] = playerChar; break;
                case 9: playField[2, 2] = playerChar; break;

            }
            
        }

        public static void ResetGame()
        {
             char[,] playFieldInitial =
                {
                    {'1','2','3' },
                    {'4','5','6' },
                    {'7','8','9' }
                };
            playField = playFieldInitial;
            SetField();
            turns = 0;
        }
    }
}
