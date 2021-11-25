using System;

namespace pyrikova.Domain
{
    public class Visitor
    {
        public int VisitorCode { get; set; } //код посетителя
        public DateTime SubscriptionActivationDate { get; set; } //дата активации абонемента
        public string Telephone { get; set; } //номер телефона
        public DateTime DateOfBirth { get; set; } //дата рождения
        public string Fio { get; set; } //ФИО посетителя
    }
}