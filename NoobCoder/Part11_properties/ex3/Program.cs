using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();
            var ADate = new Date(160, 13, 1999);
            var NDate = ADate.Next();
            var PDate = ADate.Previous();
            Console.WriteLine("==========================================");
            ADate.Print();
            NDate.Print();
            PDate.Print();
            Console.WriteLine("==========================================");
            ADate.PrintForward(5);
            Console.WriteLine("==========================================");
            ADate.PrintBackward(5);


        }
    }
    class Date
    {
        //-----------------------------------------------------------------
        private int _day;
        private int _month;
        private int _year;
        private bool _leap;
        //-----------------------------------------------------------------
        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }
        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        //-----------------------------------------------------------------
        // constructor
        public Date(int day, int month, int year)
        {
            if (year < 0 && month < 0 && day < 0)
            {
                year = Math.Abs(year);
                month = Math.Abs(month);
                day = Math.Abs(day);
            }

            do
            {
                CheckLeapYear(year);
                if (day <= 0)
                {
                    month--;
                    month = ValidateMonth(month, ref year);
                    day += CheckDaysInMonth(month);

                }
                month = ValidateMonth(month, ref year);
                year = ValidateYear(year);
                if (month > 12)
                {
                    year += month / 12;
                    month %= 12;
                }
                CheckLeapYear(year);
                var maxdays = CheckDaysInMonth(month);
                if (day > maxdays)
                {
                    while (day > maxdays)
                    {
                        month++;
                        month = ValidateMonth(month, ref year);
                        day -= maxdays;
                        maxdays = CheckDaysInMonth(month);
                    }
                }
            }
            while (day > 31 || day < 1 || month > 12 || month < 1);
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }
        /*
        * constructor methods
        */
        //-----------------------------------------------------------------
        private int ValidateYear(int year) => year < 0 ? 1 : year;
        private int ValidateMonth(int month, ref int year)
        {
            if (month <= 0)
            {
                year -= Math.Abs(month / 12) > 0 ? Math.Abs(month / 12) : 1;
                month = Math.Abs(month % 12) > 0 ? Math.Abs(month % 12) : 12;
            }
            return month;
        }
        private int CheckDaysInMonth(int month)
        {
            var maxdays = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    maxdays = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    maxdays = 30;
                    break;
                case 2:
                    if (_leap)
                        maxdays = 29;
                    else
                        maxdays = 28;
                    break;
                default:
                    maxdays = 31;
                    break;
            }
            return maxdays;
        }
        private void CheckLeapYear(int year)
        {
            if (year % 4 == 0 && year % 10 != 0 || year % 400 == 0)
            {
                _leap = true;
            }
            else
            {
                _leap = false;
            }
        }
        //-----------------------------------------------------------------
        public void Print() => Console.WriteLine("The {0} of {1} {2}", this.Day, (MonthsInYears)this.Month, this.Year);
        public Date Next() => new Date(this.Day + 1, this.Month, this.Year);
        public Date Previous() => new Date(this.Day - 1, this.Month, this.Year);

        public void PrintForward(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Date c = new Date(this.Day + i, this.Month, this.Year);
                c.Print();
            }
        }
        public void PrintBackward(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Date c = new Date(this.Day - i, this.Month, this.Year);
                c.Print();
            }
        }

    }
    enum MonthsInYears
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12,
    }
    enum DaysInMonths
    {
        January = 31,
        February = 28,
        March = 31,
        April = 30,
        May = 31,
        June = 30,
        July = 31,
        August = 31,
        September = 30,
        October = 31,
        November = 30,
        December = 31,
    }
    enum DaysInLeapMonths
    {
        January = 31,
        February = 28,
        March = 31,
        April = 30,
        May = 31,
        June = 30,
        July = 31,
        August = 31,
        September = 30,
        October = 31,
        November = 30,
        December = 31,
    }
}