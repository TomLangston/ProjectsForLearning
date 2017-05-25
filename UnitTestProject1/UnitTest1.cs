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
        public void TestSessionTotalShouldBeBiggerThanZero()
        {
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
            int fee = Erdem.CalculateTotalFee();
            Assert.IsTrue(fee>0);
        }
    }
}
