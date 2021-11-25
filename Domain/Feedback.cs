using System;

namespace pyrikova.Domain
{
    public class Feedback
    {
        public int Code { get; set; } //код отзыва
        public DateTime DateRecord { get; set; } //дата отзыва
        public int CoachsCode { get; set; } //код тренера
        public int Estimation { get; set; } //оценка
        public string Comment { get; set; } //комментарий
    }
}