using System;
using System.Collections.Generic;
using System.Text;

namespace _09_01_Polymorphic_Parameters
{
    public class Car
    {
        protected string HP { get; set; }
        protected string Color { get; set; }

        // has a relationship
        protected CarIDInfo carIDinfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDinfo.IDNum = idNum;
            carIDinfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the id of {0} and is owned by {1}", carIDinfo.IDNum, carIDinfo.Owner);
        }

        public Car()
        {
            this.HP = "135";
            this.Color = "Black";
        }

        public Car(string hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("This Car has {0} power HP and color {1}", this.HP, this.Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("car was repaired!");
        }
    }
}
