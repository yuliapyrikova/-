using System;

namespace pyrikova.Domain
{
    /// <summary>
    /// Запись на тренировку
    /// </summary>
    public class WorkoutRecord
    {
        /// <summary>
        /// Код записи
        /// </summary>
        public int WorkoutRecordId { get; set; }
        /// <summary>
        /// Дата и время записи
        /// </summary>
        public DateTime TimeAndDateOfRecording { get; set; }
        /// <summary>
        /// ФИО тренера
        /// </summary>
        public string TrainerFullName { get; set; }
    }
}