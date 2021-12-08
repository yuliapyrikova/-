namespace pyrikova.Repository
{
    public static class Storage
    {
        public static readonly AdminStorage AdminStorage = new();
        public static readonly FeedbackStorage FeedbackStorage = new();
        public static readonly CoachStorage CoachStorage = new();
        public static readonly WorkoutRecordStorage WorkoutRecordStorage = new();
        public static readonly NewsStorage NewsStorage = new();
        public static readonly PersonalDataStorage PersonalDataStorage = new();
        public static readonly ScheduleStorage ScheduleStorage = new();
        public static readonly SubscriptionStorage SubscriptionStorage = new();
    }
}