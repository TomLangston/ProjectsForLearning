using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program started");
            var cronometer = new System.Diagnostics.Stopwatch();
            cronometer.Start();
            var myList = new List<int>();
            for (double i = 0; i < 1000000; i++)
            {
                int a = 2 * 2;
                myList.Add(a);
            }
            cronometer.Stop();
            Console.WriteLine("it took the computer " + cronometer.Elapsed.TotalMilliseconds + " milliseconds.");
            Console.WriteLine("program ended");
            Console.Read();
        }
    }
}
