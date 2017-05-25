using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureofAClass.Today
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program started");
            var myPlayer = new GoalkeeperPlayer();
            myPlayer.Skills = new Skills();
            myPlayer.run();
            Console.WriteLine("program ended");
            Console.Read();
        }
        public class Stadium
        {
            class Team
            {
                public Player Player { get; set; }
            }
        }
    }

    class Skills
    {

    }

    class DefencePlayer
    {

    }

    class OffensePlayer
    {


    }

    class MidfieldPlayer
    {


    }
    /// <summary>
    /// Colons means inheritance in programming; mean you are inheriting the properties and methods e.g. Skills property.
    /// </summary>
    class GoalkeeperPlayer : Player
    {//todo:override explain how to do override
        public void run()
        {
            Console.WriteLine("my goalkeeper is running");
        }
    }

    class Player
    {
        public Program.Stadium Stadium { get; set; }
        public Skills Skills { get; set; }
        public void run()
        {
            Console.WriteLine("my player is running");
        }
    }
}
