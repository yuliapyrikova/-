using System;

namespace pyrikova.Domain
{
    /// <summary>
    /// Отзывы
    /// </summary>
    public class Feedback
    {
        /// <summary>
        /// Код отзывв
        /// </summary>
        public int FeedbackId { get; set; }
        /// <summary>
        /// Дата и время отзыва
        /// </summary>
        public DateTime DateRecall { get; set; }
        /// <summary>
        /// Код тренера
        /// </summary>
        public int CoachsCode { get; set; }
        /// <summary>
        /// Оценка
        /// </summary>
        public int Estimation { get; set; }
        /// <summary>
        /// Комметарий
        /// </summary>
        public string Comment { get; set; }
    }
}