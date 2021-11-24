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
            Newss.Add(news.PlacementCode, news);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public News Read(int placementCode)
        {
            return Newss[placementCode];
        }

        public News Update(int placementCode, News newNews)
        {
            Newss[placementCode] = newNews;
            return Newss[placementCode];
        }

        public bool Delete(int placementCode)
        {
            return Newss.Remove(placementCode);
        }
    }
}