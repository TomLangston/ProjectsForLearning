using System.Collections.Generic;

namespace TutorCalculator
{
    public class Teacher
    {
        private string _nameValue;
        private string _skillsValue;
        private string _qualificationsValue;
        public List<Student> StudentList
        { get; set; }
        public string Name
        {
            get { return _nameValue; }

            set
            {
                _nameValue = value;
            }
        }

        public string Skills
        {
            get
            {
                return _skillsValue;
            }

            set
            {
                _skillsValue = value;
            }
        }

        public string Qualifications
        {
            get
            {
                return _qualificationsValue;
            }

            set
            {
                _qualificationsValue = value;
            }
        }

        public int CalculateTotalPrice()
        {
            var result = 0;
            foreach (var myStudent in StudentList)
            {
                foreach (var mySessions in myStudent.SessionsList)
                {
                    result += mySessions.Price*mySessions.Length;
                }
            }
            return result;

        }
    }
}