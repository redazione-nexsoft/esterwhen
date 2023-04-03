namespace esterwhen
{
    public class ConwayEasterWhenCalculator : EaterWhenCalculator
    {
        public DateTime Calculate(int year)
        {
            int golden = year % 19 + 1;
            int century = year / 100 + 1;
            int X = (3 * century) / 4 - 12;
            int Y = (8 * century + 5) / 25 - 5;
            int Z = (5 * year) / 4 - X - 10;
            int C = 20 + Y - X;
            int epac = (11 * golden + C) % 30;
            if (epac == 24) epac++; 
            if ((epac == 25) && (golden > 11)) epac++; 
            int N = 44 - epac;
            if (N < 21) { N = N + 30; }
            int P = (N + 7) - ((Z + N) % 7);
            int month = 3;
            if (P > 31)
            {
                P = P - 31;
                month = 4;
            }
            return new DateTime(year, month, P);
        }
         
    }
}