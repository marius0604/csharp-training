using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name:");
            string name=Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night?");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, "+ name);
            if (hours > 8)
                Console.WriteLine("You are well rested.");
            else
                Console.WriteLine("You need more sleep.");
        }
    }
}
