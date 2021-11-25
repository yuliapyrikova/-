using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class ScheduleStorage
    {
        private readonly Dictionary<int, Schedule> _schedules = new();

        public Schedule Create(Schedule schedule)
        {
            // var id = _schedules.Keys.Last() + 1;
            var id = _schedules.Keys.Max() + 1;
            schedule.Id = id;
            _schedules.Add(schedule.Id, schedule);
            return schedule;
            //var command = Schedule.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Schedule Read(int id)
        {
            return Schedules[id];
        }

        public Schedule Update(int id, Schedule newSchedule)
        {
            Schedules[id] = newSchedule;
            return Schedules[id];
        }

        public bool Delete(int id)
        {
            return Schedules.Remove(id);
        }
    }
}