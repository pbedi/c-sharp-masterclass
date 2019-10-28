using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Interfaces
{
    public class Notification: INotifications
    {
        private string sender;
        private string message;
        private string date;

        public void showNotifications()
        {
            Console.WriteLine("{1} sent by {2} on {0}", this.getDate(), this.message, this.sender);
        }

        public string getDate()
        {
            return date;
        }
        public Notification()
        {
            this.sender = "Admin";
            this.message = "How are you?";
            this.date = "  ";
        }

        public Notification(string sender, string message, string date)
        {
            this.sender = sender;
            this.message = message;
            this.date = date;
        }
    }
}
