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
            int firstWeekWorkDays;

            if(workDays < 5)
            {
                if((int)current.DayOfWeek + workDays - 1 > 5)
                {
                    firstWeekWorkDays = (5 - (int)current.DayOfWeek + 1);
                    return firstWeekWorkDays + 2 + (workDays - firstWeekWorkDays);
                }
                else
                {
                    return workDays;
                }
                
            }

            int total;
            firstWeekWorkDays = (5 - (int)current.DayOfWeek + 1);
            workDays -= firstWeekWorkDays;
            total = firstWeekWorkDays + 2;
            int fullWorkWeeksPassed = (workDays - 1) / 5;
            total += (fullWorkWeeksPassed * 7);
            workDays -= (fullWorkWeeksPassed * 5);
            total += workDays;

            return total;
        }
    }
}