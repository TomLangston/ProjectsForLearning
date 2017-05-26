using System;

namespace TutorCalculator
{
    public class Session
    {
        public string Subject { get; set; }
        private DateTime _dateValue;
        private int _lengthValue;
        private int _priceValue;

        public Session()
        {
            this.Price = 16;
        }


        public DateTime Date
        {
            get { return _dateValue; }

            set { _dateValue = value; }
        }

        public int Length
        {
            get { return _lengthValue; }

            set { _lengthValue = value; }
        }

        public int Price
        {
            get { return _priceValue; }

            set { _priceValue = value; }
        }
    }
}