using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class PersonalDataStorage3
    {
        private Dictionary<int, PersonalData> PersonalDatas { get; } = new Dictionary<int, PersonalData>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public PersonalDataStorage3() => Connection.Open();

        public void Create(PersonalData personalData)
        {
            PersonalDatas.Add(personalData.VisitorCode, personalData);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public PersonalData Read(int visitorCode)
        {
            return PersonalDatas[visitorCode];
        }

        public PersonalData Update(int visitorCode, PersonalData newPersonalData)
        {
            PersonalDatas[visitorCode] = newPersonalData;
            return PersonalDatas[visitorCode];
        }

        public bool Delete(int visitorCode)
        {
            return PersonalDatas.Remove(visitorCode);
        }
    }
}