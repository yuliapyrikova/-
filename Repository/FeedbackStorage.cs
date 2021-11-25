using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class FeedbackStorage
    {
        private readonly Dictionary<int, Feedback> _feedbacks = new();

        public Feedback Create(Feedback feedback)
        {
            // var id = _feedbacks.Keys.Last() + 1;
            var id = _feedbacks.Keys.Max() + 1;
            feedback.Id = id;
            _feedbacks.Add(feedback.Id, feedback);
            return feedback;
            //var command = Feedback.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Feedback Read(int id)
        {
            return _feedbacks[id];
        }

        public Feedback Update(int id, Feedback newFeedback)
        {
            _feedbacks[id] = newFeedback;
            return _feedbacks[id];
        }

        public bool Delete(int id)
        {
            return _feedbacks.Remove(id);
        }
    }
}