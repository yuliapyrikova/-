namespace pyrikova.Domain
{
    /// <summary>
    /// Новости тренажерного клуба
    /// </summary>
    public class News
    {
        /// <summary>
        /// Код новости
        /// </summary>
        public int NewsId { get; set; } 
        /// <summary>
        /// Заголовок новости
        /// </summary>
        public string Heading { get; set; } 
        /// <summary>
        /// Введение
        /// </summary>
        public string Introduction { get; set; } 
        /// <summary>
        /// Основая часть
        /// </summary>
        public string TheMainPart { get; set; } 
        /// <summary>
        /// Фото
        /// </summary>
        public string Photo { get; set; } 
        /// <summary>
        /// Видео
        /// </summary>
        public string Video { get; set; } 
    }
}