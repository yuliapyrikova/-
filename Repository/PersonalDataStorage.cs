using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class PersonalDataStorage
    {
        private Dictionary<int, PersonalData> PersonalDatas { get; } = new Dictionary<int, PersonalData>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public PersonalDataStorage() => Connection.Open();

        public void Create(PersonalData personalData)
        {
            PersonalDatas.Add(personalData.PersonalDataId, personalData);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public PersonalData Read(int personalDataId)
        {
            return PersonalDatas[personalDataId];
        }