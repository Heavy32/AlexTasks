using System;
using System.Linq;

namespace WorkDays
{
    public class WorkDays
    {
        public int WorkDaysCounter(DateTime current, int workDays, int i)
        {
            if ((current.DayOfWeek != DayOfWeek.Saturday) && (current.DayOfWeek != DayOfWeek.Sunday))
                workDays--;

            return (workDays == 0) ? ++i : WorkDaysCounter(current.AddDays(1), workDays, ++i);
        }
    }
}