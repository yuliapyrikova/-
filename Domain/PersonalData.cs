using System;

namespace pyrikova.Domain
{
    /// <summary>
    /// Личные данные пользователя
    /// </summary>
    public class PersonalData
    {
        /// <summary>
        /// Код пользователя
        /// </summary>
        public int PersonalDataId { get; set; }
        /// <summary>
        /// Дата активации абонемента
        /// </summary>
        public DateTime SubscriptionActivationDate { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string Fio { get; set; }
    }
}