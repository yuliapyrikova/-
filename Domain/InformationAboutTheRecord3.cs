class Coach
{
    public int RecordCode { get; set; } //код записи
    class Data
       { 
            int day;
            int month;
            int year;
       }
    public Data TimeAndDateOfRecording { get; set; } //дата и время записи
    public string TrainerFullName { get; set; } //ФИО тренера
}