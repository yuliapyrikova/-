using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class WorkoutRecordStorage
    {
        private readonly Dictionary<int, WorkoutRecord> _workoutRecords = new();

        public WorkoutRecord Create(WorkoutRecord workoutRecord)
        {
            // var id = _workoutRecords.Keys.Last() + 1;
            var id = _workoutRecords.Keys.Max() + 1;
            workoutRecord.Id = id;
            _workoutRecords.Add(workoutRecord.Id, workoutRecord);
            return workoutRecord;
            //var command = WorkoutRecord.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public WorkoutRecord Read(int id)
        {
            return WorkoutRecords[id];
        }

        public WorkoutRecord Update(int id, WorkoutRecord newWorkoutRecord)
        {
            WorkoutRecords[id] = newWorkoutRecord;
            return WorkoutRecords[id];
        }
    }
}