class Schedule
{
    public int Code { get; set; } //код расписания
    {
    FreeDays = new DateTime()
    }
    public DateTime FreeDays { get; set; } //свободные дни
    {
    BusyDays = new DateTime()
    }
    public DateTime BusyDays { get; set; } //занятые дни
    public int TrainerCode { get; set; } //код тренера
}