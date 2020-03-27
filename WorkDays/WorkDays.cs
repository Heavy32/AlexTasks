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
        {
            int dayNumberOfWeek = (int)current.DayOfWeek;
            int fullWeeksPassed = ((workDays - 1) / 5);
            return (7 - dayNumberOfWeek + 1) + ((fullWeeksPassed - 1) * 7) + (workDays - fullWeeksPassed * 5);
        }
    }
}