using System.Collections.Generic;

namespace TutorCalculator
{
    public class Student
    {
        private string _nameValue;
        private string _emailValue;
        private string _locationValue;
        public List<Session> SessionsList { get; set; }
        public string Name
        {
            get { return _nameValue; }

            set { _nameValue = value; }
        }

        public string Email
        {
            get { return _emailValue; }

            set { _emailValue = value; }
        }

        public string Location
        {
            get { return _locationValue; }

            set { _locationValue = value; }
        }

        public int TotalSessionCount()
        {
            var result = 0;
            foreach (var mySession in SessionsList)
            {
                result += 1;
            }
            return result;
        }
    }
}