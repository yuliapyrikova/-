using System;

namespace pyrikova.Domain
{

    public class Schedule
    {
 
        public int ScheduleId { get; set; }

        public DateTime FreeDays { get; set; }

        public DateTime BusyDays { get; set; }

        public int TrainerCode { get; set; }
    }
}