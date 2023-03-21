using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Util
{
    public class ScheduleHelper
    {
        private static int artisans;
        public static int Artisans
        {
            get
            {
                if (artisans == 0)
                    artisans = int.Parse(ConfigurationManager.AppSettings.Get("artisans"));
                return artisans;
            }
        }

        private static int weeklyHours;
        public static int WeeklyHours
        {
            get
            {
                if (weeklyHours == 0)
                    weeklyHours = int.Parse(ConfigurationManager.AppSettings.Get("weeklyHours"));
                return weeklyHours;
            }
        }

        private static float efficientHours;
        public static float EfficientHours
        {
            get
            {
                if (efficientHours == 0)
                    efficientHours = float.Parse(ConfigurationManager.AppSettings.Get("efficientHours"));
                return efficientHours;
            }
        }

        public static DateTime GetEndDate(DateTime startDate, int hours)
        {
            // Get daily workable hours
            float dailyHours = ((WeeklyHours * EfficientHours) / 5) * Artisans;

            int workingDays = (int)Math.Ceiling(hours / dailyHours);

            // Get end date (minus one day to account for the start date).
            DateTime endDate = AddWorkingDays(startDate, (workingDays - 1));

            return endDate;
        }

        // Referenced: https://stackoverflow.com/questions/4604461/c-sharp-datetime-to-add-subtract-working-days
        public static DateTime AddWorkingDays(DateTime startDateate, int workDays)
        {
            DateTime endDateate = startDateate;
            while (workDays > 0)
            {
                endDateate = endDateate.AddDays(1);
                if (endDateate.DayOfWeek != DayOfWeek.Saturday && endDateate.DayOfWeek != DayOfWeek.Sunday)
                    workDays--;
            }
            return endDateate;
        }

        // Referenced: https://stackoverflow.com/questions/1617049/calculate-the-number-of-business-days-between-two-dates
        public static int GetWorkingDays(DateTime startDate, DateTime endDate)
        {
            double workingDays = 1 + ((endDate - startDate).TotalDays * 5 - (startDate.DayOfWeek - endDate.DayOfWeek) * 2) / 7;

            if (endDate.DayOfWeek == DayOfWeek.Saturday) workingDays--;
            if (startDate.DayOfWeek == DayOfWeek.Sunday) workingDays--;

            return (int)workingDays;
        }
    }
}
