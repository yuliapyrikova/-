using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class AdminStorage
    {
        private Dictionary<int, Admin> Admins { get; } = new Dictionary<int, Admin>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AdminStorage() => Connection.Open();

        public void Create(Admin admin)
        {
            Admins.Add(admin.AdminCode, admin);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Admin Read(int adminCode)
        {
            return Admins[adminCode];
        }

        public Admin Update(int authorCode, Author newAuthor)
        {
            Admins[adminCode] = newAdmin;
            return Admins[adminCode];
        }

        public bool Delete(int adminCode)
        {
            return Admins.Remove(adminCode);
        }
    }
}