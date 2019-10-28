using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Inheritance_Demo
{
    public class Post
    {
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Philip Bedi";
        }

        // Instance construtor that has three parameters
        public Post (string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // method override of the ToString method hich is inherited
        // from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by - {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
