using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalStatements
{
    class Program
    {
        public Program()
        {
                
        }
        static void Main(string[] args)
        {
            FindTimeFor2X2();
            var result = FindTimeForMillionOperation();
            Console.WriteLine("Operation for a million results takes " + result);
            Console.Read();
        }

        private static void FindTimeFor2X2()
        {
            Console.WriteLine("program started");
            var cronometer = new System.Diagnostics.Stopwatch();
            cronometer.Start();
            int a = 2 * 2;
            cronometer.Stop();
            Console.WriteLine("it took the computer " + cronometer.Elapsed.TotalMilliseconds + " milliseconds.");
            Console.WriteLine("program ended");
        }
        private static string FindTimeForMillionOperation()
        {
            Console.WriteLine("program started");
            var cronometer = new System.Diagnostics.Stopwatch();
            cronometer.Start();
            for (int i = 0; i < 1000000; i++)
            {
                int a = 2 * 2;
            }
            cronometer.Stop();
            Console.WriteLine("it took the computer " + cronometer.Elapsed.TotalMilliseconds + " milliseconds.");
            Console.WriteLine("program ended");
            return cronometer.Elapsed.TotalMilliseconds.ToString();
        }
    }
}
