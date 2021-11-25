using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class CoachStorage
    {
        private readonly Dictionary<int, Coach> _coachs = new();

        public Coach Create(Coach coach)
        {
            // var id = _coachs.Keys.Last() + 1;
            var id = _coachs.Keys.Max() + 1;
            coach.Id = id;
            _coachs.Add(coach.Id, coach);
            return coach;
            //var command = Coach.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Coach Read(int id)
        {
            return Coachs[id];
        }

        public Coach Update(int id, Coach newCoach)
        {
            Coachs[id] = newCoach;
            return Coachs[id];
        }
    }
}