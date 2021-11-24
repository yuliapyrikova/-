using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class InfAboutTheCoachStorage6
    {
        private Dictionary<int, InfAboutTheCoach> InfAboutTheCoachs { get; } = new Dictionary<int, InfAboutTheCoach>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public InfAboutTheCoachStorage6() => Connection.Open();

        public void Create(InfAboutTheCoach infAboutTheCoach)
        {
            InfAboutTheCoachs.Add(infAboutTheCoach.TrainerCode, infAboutTheCoach);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public InfAboutTheCoach Read(int trainerCode)
        {
            return InfAboutTheCoachs[trainerCode];
        }

        public InfAboutTheCoach Update(int trainerCode, InfAboutTheCoach newInfAboutTheCoach)
        {
            InfAboutTheCoachs[trainerCode] = newInfAboutTheCoach;
            return InfAboutTheCoachs[trainerCode];
        }

        public bool Delete(int trainerCode)
        {
            return InfAboutTheCoachs.Remove(trainerCode);
        }
    }
}