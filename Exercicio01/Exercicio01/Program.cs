using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            public static int GetDifDias(DateTime initialDate, DateTime finalDate)
            {
                var days = 0;
                var daysCount = 0;
                days = initialDate.Subtract(finalDate).Days;

                if (days < 0)
                    days = days * -1;

                for (int i = 1; i <= days; i++)
                {
                    initialDate = initialDate.AddDays(1);

                    if (initialDate.DayOfWeek != DayOfWeek.Sunday &&
                        initialDate.DayOfWeek != DayOfWeek.Saturday)
                        daysCount++;
                }
                return daysCount;
            }
        }
    }
}