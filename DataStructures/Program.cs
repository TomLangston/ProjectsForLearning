using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program started");
            var myBall = new Ball();
            myBall.colour = "White";
            myBall.radius = 30;
            var myBallTwo = new Ball();
            myBallTwo.colour = "Black";
            myBallTwo.radius = 25;
            var myField = new Field();
            myField.Balls = new List<Ball>();
            myField.Balls.Add(myBall);
            myField.Balls.Add(myBallTwo);
            Console.WriteLine("There are this many balls in the field:"+myField.Balls.Count);
            Console.WriteLine("program ended");
            Console.Read();
        }
    }

    public class Ball
    {
        public int radius { get; set; }
        public string colour { get; set; }
    }

    public class Field
    {
        public List<Ball> Balls { get; set; }
    }
}
