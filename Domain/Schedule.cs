using System;

namespace pyrikova.Domain
{
    public class Schedule
    {
        public int Code { get; set; } //код расписания
        public DateTime FreeDays { get; set; } //свободные дни
        public DateTime BusyDays { get; set; } //занятые дни
        public int TrainerCode { get; set; } //код тренера
    }
}