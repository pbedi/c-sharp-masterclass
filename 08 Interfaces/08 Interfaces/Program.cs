using System;

namespace _08_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification note1 = new Notification("Philip", "When are you coming?", "24 Oct 2019");
            note1.showNotifications();

        }
    }
}
