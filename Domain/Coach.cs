using System;

namespace pyrikova.Domain
{
    /// <summary>
    /// Тренер тренажёрного клуба
    /// </summary>
    public class Coach
    {
        /// <summary>
        /// Код тренера
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Дата рождения тренера
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// ФИО тренера
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Расписание тренера
        /// </summary>
        public string Schedule { get; set; }
        /// <summary>
        /// Стаж работы
        /// </summary>
        public int Experience { get; set; }
        /// <summary>
        /// Рейтинг тренера
        /// </summary>
        public float Rating { get; set; }
    }
}