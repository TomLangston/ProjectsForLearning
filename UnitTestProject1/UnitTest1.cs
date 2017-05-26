using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DefiningClasses;
using TutorCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestPlayerConstructors()
        {
            var myPlayer = new player("Sanchez", 0);
        }

        [TestMethod]
        public void TestSessionPrice()
        {
            var erdem = createTeacher();
            int fee = erdem.CalculateTotalPrice();
            Assert.IsTrue(fee>0, "The fee should be bigger than zero");
            Assert.IsTrue(fee>69, "The fee should be bigger than 69"); //I am trying to catch a logical error
            // This is confusing, is it smaller than 96? False. Should create an error.
            Assert.IsFalse(fee<100, "This fee should be bigger than 100, there is more than 6 sessions. Some sessions can have more than one hour. Total calculated fee = {0}", fee);
        }

        [TestMethod]
        public void TestSessionTotalPrice()
        {
            var erdem = createTeacher();
            int fee = erdem.CalculateTotalPrice();
            Assert.IsTrue(erdem.StudentList[0].SessionsList[1].TotalPrice()==32, "The second class was for two hours and it cost 32 pounds.");
        }

        [TestMethod]
        public void TestStudentValues()
        {
            var erdem = createTeacher();
            
            Assert.IsTrue(erdem.StudentList[0].TotalSessionCount() > 0, "The total session count should be bigger than zero");
            Assert.AreEqual(erdem.StudentList[0].TotalSessionCount(),6, "It should have six sessions");
        }

        private static Teacher createTeacher()
        {
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
            return erdem;
        }
    }
}
