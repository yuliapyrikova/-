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
            Feedbacks.Add(feedback.FeedbackId, feedback);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Feedback Read(int feedbackId)
        {
            return Feedbacks[feedbackId];
        }

        public Feedback Update(int feedbackId, Feedback newFeedback)
        {
            Feedbacks[feedbackId] = newFeedback;
            return Feedbacks[feedbackId];
        }

        public bool Delete(int feedbackId)
        {
            return Feedbacks.Remove(feedbackId);
        }
    }
}