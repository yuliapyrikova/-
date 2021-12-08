using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class ScheduleStorage
    {
        private Dictionary<int, Schedule> Schedules { get; } = new Dictionary<int, Schedule>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public ScheduleStorage() => Connection.Open();

        public void Create(Schedule schedule)
        {
            Schedules.Add(schedule.ScheduleId, schedule);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Schedule Read(int scheduleId)
        {
            return Schedules[scheduleId];
        }

        public Schedule Update(int scheduleId, Schedule newSchedule)
        {
            Schedules[scheduleId] = newSchedule;
            return Schedules[scheduleId];
        }

        public bool Delete(int scheduleId)
        {
            return Schedules.Remove(scheduleId);
        }
    }
}