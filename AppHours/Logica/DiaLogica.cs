using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHours.Dao
{
    public static class DiaLogica
    {
        static string[] week = { "MO","TU","WE","TH","FR"};
        static string[] weekend = { "SA", "SU"};

        public static bool isWeek(string dia)
        {
            return week.ToList().Contains(dia);
        }
        public static bool isWeekend(string dia)
        {
            return weekend.ToList().Contains(dia);
        }

        
    }
}
