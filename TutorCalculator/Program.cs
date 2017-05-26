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
            var erdem = new Teacher
            {
                Skills = "C#, Unity, Games",
                Name = "Erdem",
                Qualifications = "Microsoft Certified Professional"
            };
            var tom = new Student
            {
                Email = "tomlangston07@gmail.com",
                Location = "Worcestershire",
                Name = "Tom"
            };
            erdem.StudentList = new List<Student> {tom};
            var sessionOne = new Session
            {
                Date = new DateTime(2017, 5, 21, 16, 0, 0),
                Length = 1
            };
            var sessionTwo = new Session
            {
                Date = new DateTime(2017, 5, 22, 16, 0, 0),
                Length = 2
            };
            var sessionThree = new Session
            {
                Date = new DateTime(2017, 5, 23, 16, 0, 0),
                Length = 2
            };
            var sessionFour = new Session
            {
                Date = new DateTime(2017, 5, 24, 16, 0, 0),
                Length = 1
            };
            var sessionFive = new Session
            {
                Date = new DateTime(2017, 5, 25, 16, 0, 0),
                Length = 2
            };
            var sessionSix = new Session
            {
                Date = new DateTime(2017, 5, 26, 16, 0, 0),
                Length = 2
            };
            tom.SessionsList = new List<Session> {sessionOne, sessionTwo, sessionThree, sessionFour, sessionFive, sessionSix};
            Console.WriteLine("Session Five Date is "+sessionFive.Date);
            Console.WriteLine("There are this many students in the list: " + erdem.StudentList.Count);
            Console.WriteLine("The calculated fee is "+erdem.CalculateTotalPrice());
            Console.WriteLine("program ended");
            Console.Read();
        }
    }
}
