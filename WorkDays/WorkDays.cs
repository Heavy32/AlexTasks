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
            int total = 0;
            int firstWeekWorkDays;

            if(workDays < 5)
            {
                if((int)current.DayOfWeek + workDays - 1 > 5)
                {
                    firstWeekWorkDays = (5 - (int)current.DayOfWeek + 1);
                    total = firstWeekWorkDays + 2 + (workDays - firstWeekWorkDays);
                    return total;
                }
                else
                {
                    return workDays;
                }
                
            }

            firstWeekWorkDays = (5 - (int)current.DayOfWeek + 1);
            workDays = workDays - firstWeekWorkDays;
            total = (5 - (int)current.DayOfWeek + 1) + 2;
            int fullWorkWeeksPassed = (workDays - 1) / 5;
            total += (fullWorkWeeksPassed * 7);
            workDays = workDays - (fullWorkWeeksPassed * 5);
            total += workDays;

            return total;
        }
    }
}