using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class InfAboutTheRecStorage
    {
        private Dictionary<int, InfAboutTheRec> InfAboutTheRecs { get; } = new Dictionary<int, InfAboutTheRec>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public InfAboutTheRecStorage() => Connection.Open();

        public void Create(InfAboutTheRec infAboutTheRec)
        {
            InfAboutTheRecs.Add(infAboutTheRec.RecordCode, infAboutTheRec);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public InfAboutTheRec Read(int recordCode)
        {
            return InfAboutTheRecs[recordCode];
        }

        public InfAboutTheRec Update(int recordCode, InfAboutTheRec newInfAboutTheRec)
        {
            InfAboutTheRecs[recordCode] = newInfAboutTheRec;
            return InfAboutTheRecs[recordCode];
        }
    }
}