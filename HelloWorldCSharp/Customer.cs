using System.Collections.Generic;

namespace HelloWorldCSharp
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            var orders = new List<Order>();
        }
        public Customer(int Id)
            :this()
        {
            this.Id = Id;
        }
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
    }

}
