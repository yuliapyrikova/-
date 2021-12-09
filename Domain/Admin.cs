namespace pyrikova.Domain
{
    /// <summary>
    /// Администратор тренажерного клуба
    /// </summary>
    public class Admin
    {
        /// <summary>
        /// Код администратора
        /// </summary>
        public int AdminId { get; set; }
        /// <summary>
        /// Новости
        /// </summary>
        public int New { get; set; }
        /// <summary>
        /// Абонемент
        /// </summary>
        public int Subscription { get; set; }
    }
}
