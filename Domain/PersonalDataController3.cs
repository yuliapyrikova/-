class Visitor
{
    public int VisitorCode { get; set; } //код посетителя
    class Date
    {
        int day;
        int month;
        int year;
    }
    public Date SubscriptionActivationDate { get; set; } //дата активации абонемента
    public string Telephone { get; set; } //номер телефона
    public Date DateOfBirth { get; set; } //дата рождения
    public string FIO { get; set; } //ФИО посетителя
}