class Subscription
{
    public int Number { get; set; } //номер абонемента
    class Date
    {
        int day;
        int month;
        int year;
    }
    public Date DateOfAction { get; set; } //дата активации
}