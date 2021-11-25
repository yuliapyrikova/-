using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class AdminStorage
    {
        private readonly Dictionary<int, Admin> _admins = new();

        public Admin Create(Admin admin)
        {
            // var id = _admins.Keys.Last() + 1;
            var id = _admins.Keys.Max() + 1;
            admin.Id = id;
            _admins.Add(admin.Id, admin);
            return admin;
            //var command = Admin.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Admin Read(int adminCode)
        {
            return Admins[adminCode];
        }

        public Admin Update(int id, Admin newAdmin)
        {
            Admins[id] = newAdmin;
            return Admins[id];
        }

        public bool Delete(int id)
        {
            return Admins.Remove(id);
        }
    }
}