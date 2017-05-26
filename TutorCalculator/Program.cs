using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TutorCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program started");
            var erdem = new Teacher();
            erdem.Skills = "C#, Unity, Games";
            erdem.Name = "Erdem";
            erdem.Qualifications = "Microsoft Certified Professional";
            var tom = new Student();
            tom.Email = "tomlangston07@gmail.com";
            tom.Location = "Worcestershire";
            tom.Name = "Tom";
            erdem.StudentList = new List<Student>();
            erdem.StudentList.Add(tom);
            var sessionOne = new Session();
            sessionOne.Date = new DateTime(2017, 5, 21, 16, 0, 0);
            sessionOne.Length = 1;
            var sessionTwo = new Session();
            sessionTwo.Date = new DateTime(2017, 5, 22, 16, 0, 0);
            sessionTwo.Length = 2;
            var sessionThree = new Session();
            sessionThree.Date = new DateTime(2017, 5, 23, 16, 0, 0);
            sessionThree.Length = 2;
            var sessionFour = new Session();
            sessionFour.Date = new DateTime(2017, 5, 24, 16, 0, 0);
            sessionFour.Length = 1;
            var sessionFive = new Session();
            sessionFive.Date = new DateTime(2017, 5, 25, 16, 0, 0);
            sessionFive.Length = 2;
            Console.WriteLine("Session Five Date is "+sessionFive.Date);
            Console.WriteLine("There are this many students in the list: " + erdem.StudentList.Count);
            Console.WriteLine("program ended");
            Console.Read();
        }
    }
}
