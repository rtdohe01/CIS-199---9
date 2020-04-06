using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Date
    {
        //instance variables 
        public int year;
        public int day;
        public int month;

        //get function for year
        public int GetYear()
        {
            return year;
        }

        //set function for year.
        public void SetYear(int yr)
        {
            if (yr >= 0)//if the entered year value yr is non negative
                year = yr;//assign it with the instance variable year
            else
                year = 2019;//else assign the default value 2019
        }

        //set function for month.
        public void SetMonth(int m)
        {
            if (m >= 1 && m <= 12)//if the entered month value m >= 1 and <= 12
                month = m;//then assign it with the instance variable month.
            else
                month = 1;//else assign the default value 1
        }

        //get function for month
        public int GetMonth()
        {
            return month;
        }

        //set function for day.
        public void SetDay(int dy)
        {
            if (dy >= 1 && dy <= 31)//if the dy value is >= 1 and <= 31 
                day = dy;//then assign it to the instance variable day.
            else
                day = 1;//else assign the default value 1.
        }
        //get functions to return day
        public int GetDay()
        {
            return day;
        }

        //parameterized constructor.
        public Date(int dy, int mnth, int yr)
        {
            //call the set functions for day, month and year.
            SetDay(dy);
            SetMonth(mnth);
            SetYear(yr);
        }
        //tpString() overridden function that returns a string of formatted date.
        public override string ToString()
        {
            return GetDay().ToString("00") + "/" + GetMonth().ToString("00") + "/" + GetYear().ToString("0000");
        }
    }
}
