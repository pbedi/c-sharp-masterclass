using System;
using System.Collections.Generic;
using System.Text;

namespace _07___Jagged_Array
{
    public class FriendsFamily
    {
        string[] joesFamily = new string[] { "Abi", "Clare" };
        string[] adamsFamily = new string[] { "Paul", "Marry" };
        string[] andysFamily = new string[] { "George", "Cathy" };


        public FriendsFamily()
        {
           

        }

        public void GetFriends()
        {
            string[][] friendsFamily = new string[][]
            {
                this.joesFamily,
                this.adamsFamily,
                this.andysFamily
            };
            Console.WriteLine("Friends introduction");
            Console.WriteLine("Joe introduces {0} to Adam's {1}",friendsFamily[0][0],friendsFamily[1][0]);
            Console.WriteLine("Joe introduces {0} to Adam's {1}", friendsFamily[0][1], friendsFamily[1][0]);
            Console.WriteLine("Joe introduces {0} to Adam's {1}", friendsFamily[0][1], friendsFamily[1][1]);
            Console.WriteLine("Joe introduces {0} to Adam's {1}", friendsFamily[0][0], friendsFamily[1][1]);
            Console.WriteLine("Joe introduces {0} to Andy's {1}", friendsFamily[0][0], friendsFamily[2][0]);
            Console.WriteLine("Joe introduces {0} to Andy's {1}", friendsFamily[0][0], friendsFamily[2][1]);
            Console.WriteLine("Joe introduces {0} to Andy's {1}", friendsFamily[0][1], friendsFamily[2][0]);
            Console.WriteLine("Joe introduces {0} to Andy's {1}", friendsFamily[0][1], friendsFamily[2][1]);
            Console.WriteLine("Adam introduces {0} to Andy's {1}", friendsFamily[1][0], friendsFamily[2][0]);
            Console.WriteLine("Adam introduces {0} to Andy's {1}", friendsFamily[1][1], friendsFamily[2][0]);
            Console.WriteLine("Adam introduces {0} to Andy's {1}", friendsFamily[1][1], friendsFamily[2][1]);
            Console.WriteLine("Adam introduces {0} to Andy's {1}", friendsFamily[1][1], friendsFamily[2][1]);
        }
    }
}
