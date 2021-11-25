using pyrikova.Domain;
using System.Collections.Generic;
using System.Linq;

namespace pyrikova.Repository
{
    public class CoachStorage
    {
        private readonly Dictionary<int, Coach> _coaches = new();

        public Coach Create(Coach coach)
        {
            // var id = _coachs.Keys.Last() + 1;
            var id = _coaches.Keys.Max() + 1;
            coach.Id = id;
            _coaches.Add(coach.Id, coach);
            return coach;
            //var command = Coach.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Coach Read(int id)
        {
            return _coaches[id];
        }

        public Coach Update(int id, Coach newCoach)
        {
            _coaches[id] = newCoach;
            return _coaches[id];
        }
    }
}