using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class player
    {
        public player()
        {
            Console.WriteLine("Object created");
        }

        public player(string myName)
        {
            Console.WriteLine(myName + " created");    
        }

        public player(string myName, int myAge)
        {
            myAge = myAge / myAge;
            Console.WriteLine(myName + " created" + myAge);
        }
    }
}
