class Feedback
{
    public int Code { get; set; } //код отзыва
    class Date
    {
        int day;
        int month;
        int year;
    }
    public Date DateRecord { get; set; } //дата отзыва
    public int CoachsCode { get; set; } //код тренера
    public int Estimation { get; set; } //оценка
    public string Comment { get; set; } //комментарий
}