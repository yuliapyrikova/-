using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class FeedbackStorage
    {
        private Dictionary<int, Feedback> Feedbacks { get; } = new Dictionary<int, Feedback>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public FeedbackStorage() => Connection.Open();

        public void Create(Feedback feedback)
        {
            Feedbacks.Add(feedback.ReviewCode, feedback);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Feedback Read(int reviewCode)
        {
            return Feedbacks[reviewCode];
        }

        public Feedback Update(int reviewCode, Feedback newFeedback)
        {
            Feedbacks[reviewCode] = newFeedback;
            return Feedbacks[reviewCode];
        }

        public bool Delete(int reviewCode)
        {
            return Feedbacks.Remove(reviewCode);
        }
    }
}