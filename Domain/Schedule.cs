using System;

namespace pyrikova.Domain
{
    /// <summary>
    /// Расписание
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Код расписания
        /// </summary>
        public int ScheduleId { get; set; }
        /// <summary>
        /// Свободные время и дата
        /// </summary>
        public DateTime FreeDays { get; set; }
        /// <summary>
        /// Занятые время и дата
        /// </summary>
        public DateTime BusyDays { get; set; }
        /// <summary>
        /// Код тренера
        /// </summary>
        public int TrainerCode { get; set; } //код тренера
    }
}