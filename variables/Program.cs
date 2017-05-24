using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program started");
            int minutesinagame = 90;
            string teamA = "Aston Villa";
            string teamB = "Manchester United";
            DateTime myTime = DateTime.Now;
            var millisecond = DateTime.Now.Millisecond;
            //var milliseconds = (string)DateTime.Now.Millisecond;
            var milliseconds = DateTime.Now.Millisecond.ToString();
            if (myTime.Millisecond%2==0)
                Console.WriteLine(teamA+" beats "+teamB);
            else
                Console.WriteLine(teamB + " beats " + teamA);
            Console.WriteLine("program ended");
            Console.Read();
        }
    }
}
