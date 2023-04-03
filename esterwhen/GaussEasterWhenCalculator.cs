using System;
using System.ComponentModel.DataAnnotations;

namespace esterwhen
{
    public class GaussEasterWhenCalculator : EaterWhenCalculator
    {
        public DateTime Calculate(int year)
        {
            var (M, N) = GetMN(year);
            int a = year % 19;
            int b = year % 4;
            int c = year % 7;
            int d = (19 * a + M) % 30;
            int e = (2 * b + 4 * c + 6 * d + N) % 7;
            DateTime ret;
            if ((d + e) < 10)
            {
                ret = new DateTime(year, 3, d + e + 22);
            }
            else
            {
                ret = new DateTime(year, 4, d + e - 9);
            }         
            if (ret.Month == 4 && ret.Day == 26)
            {
                ret = new DateTime(year, 4, 19);
            }
            else if (ret.Month == 4 && ret.Day == 25 && d == 28 && e == 6 && a > 10)
            {
                ret = new DateTime(year, 4, 18);
            }
            return ret;
        }
         
        private static (int M, int N) GetMN(int year)
        {
            if (year >= 1583 && year <= 1699) return (M: 22, N: 2);
            if (year >= 1700 && year <= 1799) return (M: 23, N: 3);
            if (year >= 1800 && year <= 1899) return (M: 23, N: 4);
            if (year >= 1900 && year <= 2099) return (M: 24, N: 5);
            if (year >= 2100 && year <= 2199) return (M: 24, N: 6);
            if (year >= 2200 && year <= 2299) return (M: 25, N: 0);
            if (year >= 2300 && year <= 2399) return (M: 26, N: 1);
            if (year >= 2400 && year <= 2499) return (M: 25, N: 1);
            throw new NotSupportedException("Only dates from 1583 to 2499 are supported");
        }
    }
}