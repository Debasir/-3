using System;

namespace Max3
{
    class Program
    {
        static void Main(string[] args)
        {
            Year year = new Year(new Date(2, 3, 2022));
            Console.WriteLine(year.get_day_of_week(new Date(2, 3, 2022)));
            year.set_date(new Date(1, 3, 2022));
            Console.WriteLine(year.get_date().get_day() + " " + year.get_date().get_month() + " " + year.get_date().get_year());
        }
    }
}
