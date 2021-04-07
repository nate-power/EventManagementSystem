using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCEventManagementSystem
{
    public class Date
    {
        public int year;
        public int month;
        public int day;  
        public int hour;
        public int minute;
        public DateTime timeFormat;
        public string time;

        public Date(int day, int month, int year, int hour, int minute)
        {
            this.day = day;
            this.year = year;
            this.month = month;
            this.hour = hour;
            this.minute = minute;
            // format time from datePicker in event forms
            timeFormat = new DateTime(year, month, day, hour, minute, 0);
            time = timeFormat.ToString("h:mm tt");
            
        }

        public string viewLongMonth()
        {
            switch (month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December"; ;
                default:
                    return "-";
            }
        }

        public string viewShortMonth()
        {
            switch (month)
            {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                case 4:
                    return "Apr";
                case 5:
                    return "May";
                case 6:
                    return "Jun";
                case 7:
                    return "July";
                case 8:
                    return "Aug";
                case 9:
                    return "Sep";
                case 10:
                    return "Oct";
                case 11:
                    return "Nov";
                case 12:
                    return "Dec"; ;
                default:
                    return "-";
            }
        }

        public override string ToString()
        {
            // used for event views
            string s = day + " " + viewShortMonth() + " " + year;
            s += "\nat " + time;
            return s;
        }

        public override bool Equals(object obj)
        {
            return obj is Date date &&
                   year == date.year &&
                   month == date.month &&
                   day == date.day;
        }
    }
}
