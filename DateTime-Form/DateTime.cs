using System;
using System.IO;

namespace DateTime_Form
{
    class DateTime
    {
        public int seconds;
        public int month;
        public int year;
        private int secondInDay = 86400;

        public DateTime(int seconds, int month, int year)
        {
            this.seconds = seconds;
            this.month = month;
            this.year = year;
            Validate();
        }

        public DateTime()
        {
            var nowDate = System.DateTime.Now;
            year = nowDate.Year;
            month = nowDate.Month;
            seconds = (nowDate.Day - 1) * secondInDay + nowDate.Hour * 3600 + nowDate.Minute * 60 +
                      nowDate.Second; // -1 т.к. только дни из этого всего считаются с 1, а не с 0. значит текущий номер дня - 1 = количество пройденных дней
            Validate();
        }

        public static DateTime GetNow()
        {
            return new DateTime();
        }

        public static bool operator ==(DateTime first, DateTime second)
        {
            return first.seconds == second.seconds && first.month == second.month &&
                   first.year == second.year;
        }

        public static bool operator !=(DateTime first, DateTime second)
        {
            return first.seconds != second.seconds || first.month != second.month ||
                   first.year != second.year;
        }

        public override string ToString()
        {
            return $"{seconds / secondInDay + 1} {NameMonth(month)} {year}, {DayOfWeek()}";
        }

        public string DayOfWeek()
        {
            var sum = (codeOfYear() + codeOfMonth() + seconds / secondInDay + 1);
            if ((year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) && month <= 2)
                sum--;
            var code = sum % 7;
            return DayOfWeek(code);
        }

        private int codeOfYear()
        {
            return (codeOfCentury() + year % 100 + (year % 100) / 4) % 7;
        }

        private int codeOfCentury()
        {
            return (3 - year / 100 % 4) * 2;
        }

        private int codeOfMonth()
        {
            switch (month)
            {
                case 1:
                case 10:
                    return 1;
                case 5:
                    return 2;
                case 8:
                    return 3;
                case 2:
                case 3:
                case 11:
                    return 4;
                case 6:
                    return 5;
                case 9:
                case 12:
                    return 6;
                default: return 0;
            }
        }

        int DayInPrefMonth(int month, int year)
        {
            var sumDays = 0;
            for (var currMonth = 1; currMonth < month; currMonth++)
            {
                sumDays += MaximumDayInMonth(currMonth, year);
            }

            return sumDays;
        }

        string DayOfWeek(int dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case 0: return "Суббота";
                case 1: return "Воскресенье";
                case 2: return "Понедельник";
                case 3: return "Вторник";
                case 4: return "Среда";
                case 5: return "Четверг";
                case 6: return "Пятница";
                default: return "";
            }
        }

        int DayOfYear(int day, int month, int year)
        {
            return DayInPrefMonth(month, year) + day;
        }

        string NameMonth(int numberOfMonth)
        {
            switch (numberOfMonth)
            {
                case 1: return "январь";
                case 2: return "февраль";
                case 3: return "март";
                case 4: return "апрель";
                case 5: return "май";
                case 6: return "июнь";
                case 7: return "июль";
                case 8: return "авгусь";
                case 9: return "сентябрь";
                case 10: return "октябрь";
                case 11: return "ноябрь";
                case 12: return "декабрь";
                default: return "";
            }
        }

        void Validate()
        {
            if (year < 1)
                throw new InvalidDataException("Номер года не может быть меньше 1");
            if (month < 1 || month > 12)
                throw new InvalidDataException("Номер месяца должен быть от 1 до 12");
            if (seconds < 0 || seconds >= secondInDay * MaximumDayInMonth(month, year))
                throw new InvalidDataException(
                    $"Номер секунды месяца должен быть от 0 до {secondInDay * MaximumDayInMonth(month, year) - 1}");
        }

        public void AddDays(int n)
        {
            seconds += n * secondInDay;
            if (n > 0)
                while (seconds > MaximumDayInMonth(month, year) * secondInDay)
                {
                    seconds -= MaximumDayInMonth(month, year) * secondInDay;
                    month++;
                    if (month > 12)
                    {
                        month -= 12;
                        year++;
                    }
                }
            else if (n < 0)
                while (seconds < 0)
                {
                    seconds += MaximumDayInPrefMonth(month, year) * secondInDay;
                    month--;
                    if (month <= 0)
                    {
                        month += 12;
                        year--;
                        if (year < 1)
                            throw new InvalidDataException("Номер года не может быть меньше 1");
                    }
                }
        }

        public void AddMonths(int m)
        {
            month += m;
            while (month > 12)
            {
                year++;
                month -= 12;
            }

            while (month < 0)
            {
                year--;
                if (year < 1)
                    throw new InvalidDataException("Номер года не может быть меньше 1");
                month += 12;
            }
        }

        public void AddYears(int y)
        {
            year += y;
            if (year < 1)
                throw new InvalidDataException("Номер года не может быть меньше 1");
        }

        int MaximumDayInMonth(int month, int year)
        {
            switch (month)
            {
                case 1: return 31;
                case 2: return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? 29 : 28;
                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                case 12: return 31;
                default: return 0;
            }
        }

        int MaximumDayInPrefMonth(int month, int year)
        {
            month--;
            if (month <= 0)
            {
                month += 12;
                year--;
            }

            return MaximumDayInMonth(month, year);
        }
    }
}