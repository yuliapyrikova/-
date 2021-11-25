using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class FeedbackStorage
    {
        private readonly Dictionary<int, Feedback> _feedbacks = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public FeedbackStorage() => Connection.Open();

        public void Create(Feedback feedback)
        {
            _feedbacks.Add(feedback.ReviewCode, feedback);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Feedback Read(int reviewCode)
        {
            return _feedbacks[reviewCode];
        }

        public Feedback Update(int reviewCode, Feedback newFeedback)
        {
            _feedbacks[reviewCode] = newFeedback;
            return _feedbacks[reviewCode];
        }

        public bool Delete(int reviewCode)
        {
            return _feedbacks.Remove(reviewCode);
        }
    }
}