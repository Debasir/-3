using System;
using System.Collections.Generic;
using System.Text;

namespace Max3
{
    class Year
    {
        Date date;
        string[] week = new string[] { "Понедельник",
            "Вторник", "Среда", "Четверг", "Пятница",
            "Суббота", "Воскресенье" };
    
        public Year(Date date)
        {
            this.date = date;
        }
        public string get_day_of_week(Date date)
        {
           return week[what_day(date)];
        }
        private int what_day(Date date)
        {
            int a = (14 - date.get_month()) / 12;
            int y = date.get_year() - a;
            int m = date.get_month() + 12 * a - 2;
            return ((7000 + (date.get_day() + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12)) % 7) - 1;
        }

        public void set_date(Date date)
        {
            this.date = date;
        }

        public Date get_date()
        {
            return date;
        }
    }
}
