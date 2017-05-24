using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console started");
            var messi = new player();
            var ronaldo = new player("Ronaldo");
            var cantona = new player("Cantona", 50);
            var sanchez = new player("Sanchez", 0);
            Console.WriteLine("Console ended");

            Console.Read();
        }
    }
}
