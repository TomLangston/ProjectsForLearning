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
            var Erdem = new Teacher();
            Erdem.Skills = "C#, Unity, Games";
            Erdem.Name = "Erdem";
            Erdem.Qualifications = "Microsoft Certified Professional";
            var Tom = new Student();
            Tom.Email = "tomlangston07@gmail.com";
            Tom.Location = "Worcestershire";
            Tom.Name = "Tom";
            Erdem.StudentList = new List<Student>();
            Erdem.StudentList.Add(Tom);
            var SessionOne = new Session();
            SessionOne.Date = new DateTime(2017, 5, 21, 16, 0, 0);
            SessionOne.Length = 1;
            var SessionTwo = new Session();
            SessionTwo.Date = new DateTime(2017, 5, 22, 16, 0, 0);
            SessionTwo.Length = 2;
            var SessionThree = new Session();
            SessionThree.Date = new DateTime(2017, 5, 23, 16, 0, 0);
            SessionThree.Length = 2;
            var SessionFour = new Session();
            SessionFour.Date = new DateTime(2017, 5, 24, 16, 0, 0);
            SessionFour.Length = 1;
            var SessionFive = new Session();
            SessionFive.Date = new DateTime(2017, 5, 25, 16, 0, 0);
            SessionFive.Length = 2;
            Console.WriteLine("Session Five Date is "+SessionFive.Date);
            Console.WriteLine("There are this many students in the list: " + Erdem.StudentList.Count);
            Console.WriteLine("program ended");
            Console.Read();
        }
    }

    public class Student
    {
        public List<Session> SessionsList { get; set; }
        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Email
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Location
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }

    public class Teacher
    {
        public List<Student> StudentList
        { get; set; }
        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Skills
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Qualifications
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }

    public class Session
    {
        public string Subject { get; set; }
        private DateTime DateValue;
        private int LengthValue;
        private int PriceValue;

        public Session()
        {
            this.Price = 16;
        }


        public DateTime Date
        {
            get { return DateValue; }

            set { DateValue = value; }
        }

        public int Length
        {
            get { return LengthValue; }

            set { LengthValue = value; }
        }

        public int Price
        {
            get { return PriceValue; }

            set { PriceValue = value; }
        }
    }
}
