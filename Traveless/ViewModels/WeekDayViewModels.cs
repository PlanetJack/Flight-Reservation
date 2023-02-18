using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveless.Manager.Entities;

/**
 * Instructor notes:
 */

namespace Traveless.ViewModels
{
    /// <summary>
    /// Holds view models for week days
    /// </summary>
    public class WeekDayViewModels : ObservableCollection<string>
    {
        public static readonly string WEEKDAY_ANY = "Any";
        public static readonly string WEEKDAY_SUNDAY = "Sunday";
        public static readonly string WEEKDAY_MONDAY = "Monday";
        public static readonly string WEEKDAY_TUESDAY = "Tuesday";
        public static readonly string WEEKDAY_WEDNESDAY = "Wednesday";
        public static readonly string WEEKDAY_THURSDAY = "Thursday";
        public static readonly string WEEKDAY_FRIDAY = "Friday";
        public static readonly string WEEKDAY_SATURDAY = "Saturday";

        public WeekDayViewModels()
        {
            Add(WEEKDAY_ANY);
            Add(WEEKDAY_SUNDAY);
            Add(WEEKDAY_MONDAY);
            Add(WEEKDAY_TUESDAY);
            Add(WEEKDAY_WEDNESDAY);
            Add(WEEKDAY_THURSDAY);
            Add(WEEKDAY_FRIDAY);
            Add(WEEKDAY_SATURDAY);
        }

    }
}
