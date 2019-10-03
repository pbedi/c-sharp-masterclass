using System;

namespace ConsoleOOP
{
    public class Box
    {
        public int length
        {
            get; set;
        }
        public int height { set; get; }
        public int width
        {
            set{
                if(value < 0)
                {
                    value = -value; // convert it to positive 
                }
                height = value;
               }
            get
            {
                return height;
            }
        }
        // read only
        private int volume
        {
            get
            {
                return this.height * this.length * this.width;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, volume is {1}", this.length, this.volume);
        }
    }


}
