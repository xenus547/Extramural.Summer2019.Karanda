using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public static class DateHelper
    {
        public static void curDateFull()
        {
            string[] months = {"January", "February", "March", "April", "May",
                    "June", "July","August", "September", "October", "November", "December"};
            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date time: {0}, {1} {2}, {3}", now.DayOfWeek, months[now.Month - 1], now.Day, now.Year);
        }
        public static void curDateCor()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date time: {0}/{1}/{2}", now.Month, now.Day, now.Year);
        }
    }
}
