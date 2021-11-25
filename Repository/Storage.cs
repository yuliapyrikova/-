namespace pyrikova.Repository
{
    public static class Storage
    {
        public static readonly AdminStorage AdminStorage = new();
        public static FeedbackStorage FeedbackStorage { get; } = new FeedbackStorage();
        public static InfAboutTheCoachStorage InfAboutTheCoachStorage { get; } = new InfAboutTheCoachStorage();
        public static InfAboutTheRecStorage InfAboutTheRecStorage { get; } = new InfAboutTheRecStorage();
        public static NewsStorage NewsStorage { get; } = new NewsStorage();
        public static PersonalDataStorage PersonalDataStorage { get; } = new PersonalDataStorage();
        public static ScheduleStorage ScheduleStorage { get; } = new ScheduleStorage();
        public static SubscriptionStorage SubscriptionStorage { get; } = new SubscriptionStorage();
    }
}