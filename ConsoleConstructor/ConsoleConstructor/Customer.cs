using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleConstructor
{
    public class Customer
    {
        public string Name;
        public int Id;
        public List<Order> Orders;
        //overloading 
        public Customer()
        {
            this.Orders = new List<Order>();
        }
        public Customer(int id): this()
        {
            this.Id = id;
        }
        public Customer(string name, int id) : this(id)
        {
            this.Name = name;
        }

        public Customer(string name, int id, List<Order> orders) : this(name, id)
        {
            this.Orders = orders;
        }
    }
}


