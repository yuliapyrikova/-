using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class CoachStorage
    {
        private Dictionary<int, Coach> Coachs { get; } = new Dictionary<int, Coach>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public CoachStorage() => Connection.Open();

        public void Create(Coach coach)
        {
            Coachs.Add(coach.CoachId, coach);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Coach Read(int coachId)
        {
            return Coachs[coachId];
        }

        public Coach Update(int coachId, Coach newCoach)
        {
            Coachs[coachId] = newCoach;
            return Coachs[coachId];
        }

        public bool Delete(int coachId)
        {
            return Coachs.Remove(coachId);
        }
    }
}