using System;

namespace pyrikova.Domain
{
    /// <summary>
    /// Абонемент 
    /// </summary>
    public class Subscription
    {
        /// <summary>
        /// Номер абонемента
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Дата активации абонемента
        /// </summary>
        public DateTime DateOfAction { get; set; }
    }
}