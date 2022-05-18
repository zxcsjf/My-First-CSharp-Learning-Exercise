using System;
using System.Collections.Generic;
using HelloWorldCSharp;

namespace HelloWorldCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cookies = new HttpCookie();
            cookies["name"] = "Mosh";
            Console.WriteLine(cookies["name"]);
         }

        static void UseIndexers()
        {
            var person = new Person();
            person.Birthdate = new DateTime(1999, 9, 20);
            Console.WriteLine(person.Birthdate);

           // old version
           /* var person = new Person();
            person.SetBirthday(new DateTime(1999, 9, 20));
            Console.WriteLine(person.GetBirthday());*/
        }
        static void UseObjectInitializers()
        {
           /* var person = new Person()
            {
                firstName = "jifei",
                lastName = "Shan"
            };
            Console.WriteLine(person.lastName + person.firstName);*/
        }
        static void UseTryParse()
        {
            int number;
            var result = int.TryParse("123", out number);
            if (result)      
                Console.WriteLine(number);
            else
                Console.WriteLine("An error occured.");
        }
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(1, 2, -12, -3902));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 2 }));
        }
        static void UsePoints()
        {
            try
            {
                var customer = new Customer(1, "Mosh1");
                customer.Name = "Mosh2";

                var order = new Order();
                customer.Orders = new List<Order> { };
                customer.Orders.Add(order);

                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);

                var calculator = new Calculator();
                var sum = calculator.Add(1, 3, 4);
                Console.WriteLine(sum);

                MyClass.MyMethod(out int b);
                Console.WriteLine(b);

                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("point x = {0}, point y = {1}", point.X, point.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
}
    }

}
