using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Inheritance_Demo
{
    // It is derives from post and adds a property (ImageURL) and two constructors
    class ImagePost:Post
    {
        protected string ImageURL { get; set; }

        public ImagePost()
        {
            
        }

        public ImagePost(string title, bool isPublic, string sendByUsername,string imageURL)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by - {2}, image - {3}", this.ID, this.Title, this.SendByUsername, this.ImageURL);
        }
    }
}
