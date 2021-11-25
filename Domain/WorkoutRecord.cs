using System;

namespace pyrikova.Domain
{
    public class WorkoutRecord
    {
        public int RecordCode { get; set; } //код записи
        public DateTime TimeAndDateOfRecording { get; set; } //дата и время записи
        public string TrainerFullName { get; set; } //ФИО тренера
    }
}