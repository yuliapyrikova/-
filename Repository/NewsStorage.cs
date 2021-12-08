using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class NewsStorage
    {
        private Dictionary<int, News> Newss { get; } = new Dictionary<int, News>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public NewsStorage() => Connection.Open();

        public void Create(News news)
        {
            Newss.Add(news.NewsId, news);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public News Read(int newsId)
        {
            return Newss[newsId];
        }

        public News Update(int newsId, News newNews)
        {
            Newss[newsId] = newNews;
            return Newss[newsId];
        }

        public bool Delete(int newsId)
        {
            return Newss.Remove(newsId);
        }
    }
}