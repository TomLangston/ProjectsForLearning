using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program started");
            for (int i = 0; i < 6; i++)
            {
                var myNumber1 = new Random().Next(0, 10);
                Console.Write(myNumber1);
                Console.Write(" ");
                Thread.Sleep(30);
            }
            Console.WriteLine("program ended");
            Console.Read();
        }
    }
}
