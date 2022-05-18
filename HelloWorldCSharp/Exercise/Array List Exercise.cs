using System;
using System.Collections.Generic;

// Facebook
namespace HelloWorldCSharp.Exercise
{
    class Program
    {
        static void Run()
        {
            var names = new List<string>();

            while (true)
            {
                var name = AskForName();

                if (string.IsNullOrEmpty(name))
                    break;
                names.Add(name);
                Console.WriteLine(GetLikeMessages(names));

            }
        }
        public static string AskForName()
        {
            Console.WriteLine("enter different names:");
            return Console.ReadLine();
        }

        public static string GetLikeMessages(List<string> names)
        {
            if (names.Count > 2)
                return (names[0] + "," + names[1] + "and other " + (names.Count - 2) + " person like you");
            if (names.Count == 2)
                return (names[0] + "," + names[1] + "like you");
            return (names[0] + "like you");
        }
    }
}
