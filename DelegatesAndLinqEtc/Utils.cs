using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndLinqEtc.Stuff
{
    public static class Utils
    {
        public static bool IsEven(this int x)
        {
            return x % 2 == 0;
        }

        public static DateTime DaysFromNow(this int days)
        {
            return DateTime.Now.AddDays(days);
        }

    }
}
