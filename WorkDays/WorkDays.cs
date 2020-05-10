using System;
using System.Linq;

namespace WorkDays
{
    public class WorkDays
    {
        /// <summary>
        /// Дана дата начала задачи DateTime и количество рабочих дней int для ее выполнения.
        /// Вывести количество календарных дней, которое потребуется для её выполнения.
        /// </summary>
        public int DaysCounter(DateTime current, int workDays)
            => (workDays <= 5) ? (((int)current.DayOfWeek + workDays - 1 > 5) ? (5 - (int)current.DayOfWeek + 1) + 2 + (workDays - (5 - (int)current.DayOfWeek + 1)) : workDays)
                               : (workDays - (5 - (int)current.DayOfWeek + 1) - ((workDays - (5 - (int)current.DayOfWeek + 1) - 1) / 5 * 5)
                                      + ((workDays - (5 - (int)current.DayOfWeek + 1) - 1) / 5 * 7))
                                      + (5 - (int)current.DayOfWeek + 1) + 2;

    }
}