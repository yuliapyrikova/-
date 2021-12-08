using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class WorkoutRecordStorage
    {
        private Dictionary<int, WorkoutRecord> WorkoutRecords { get; } = new Dictionary<int, WorkoutRecord>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public WorkoutRecordStorage() => Connection.Open();

        public void Create(WorkoutRecord workoutRecord)
        {
            WorkoutRecords.Add(workoutRecord.workoutRecordId, workoutRecord);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public WorkoutRecord Read(int workoutRecordId)
        {
            return WorkoutRecords[workoutRecordId];
        }

        public WorkoutRecord Update(int workoutRecordId, WorkoutRecord newWorkoutRecord)
        {
            WorkoutRecords[workoutRecordId] = newWorkoutRecord;
            return WorkoutRecords[workoutRecordId];
        }