using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class ScheduleStorage5
    {
        private Dictionary<int, Schedule> Schedules { get; } = new Dictionary<int, Schedule>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public ScheduleStorage5() => Connection.Open();

        public void Create(Schedule schedule)
        {
            Schedules.Add(schedule.ReviewCode, schedule);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Schedule Read(int scheduleCode)
        {
            return Schedules[scheduleCode];
        }

        public Schedule Update(int scheduleCode, Schedule newSchedule)
        {
            Schedules[scheduleCode] = newSchedule;
            return Schedules[scheduleCode];
        }

        public bool Delete(int scheduleCode)
        {
            return Schedules.Remove(ScheduleCode);
        }
    }
}