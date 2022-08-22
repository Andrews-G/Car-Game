using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    class Car
    {
        // Field
        private int _year;
        private string _make;
        private int _speed;

        // Constructor
        public Car(int Year, string Make)
        {
            _year = Year;
            _make = Make;
            _speed = 0;
        }

        // Constructor
        public Car()
        {
            _speed = 0;
        }

        // Year Property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Make Property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        // Speed Property
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
    }
}
