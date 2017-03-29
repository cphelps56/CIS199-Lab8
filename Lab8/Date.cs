using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Date
    {
        // Fields
        private int _day;
        private int _month;
        private int _year;

        // Constructor
        public Date(int startingDay, int startingMonth, int startingYear)
        {
            _day = startingDay;
            _month = startingMonth;
            _year = startingYear;
        }
        
        // Day property
        public int Day
        {
            get{return _day;}
            set{if(value >= 1 && value <= 31)
                _day = value;}
        }

        // Month property
        public int Month
        {
            get { return _month; }
            set{if (value >= 1 && value <= 12)
                    _month = value;}
        }

        // Year property
        public int Year
        {
            get{return _year;}
            set{if (value >= 0)
             _year = value;}
        }

        // ToString Method
        public override string ToString()
        {
            string dateString = Month.ToString("d2") + "/" + Day.ToString("d2") + "/" + Year.ToString("d4");
            return dateString;   
        }
    }
}
