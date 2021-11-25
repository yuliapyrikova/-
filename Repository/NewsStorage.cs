using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class NewsStorage
    {
        public News Create(News news)
        {
            // var id = _newss.Keys.Last() + 1;
            var id = _newss.Keys.Max() + 1;
            news.Id = id;
            _newss.Add(news.Id, news);
            return news;
            //var command = News.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public News Read(int id)
        {
            return Newss[id];
        }

        public News Update(int id, News newNews)
        {
            Newss[id] = newNews;
            return Newss[id];
        }

        public bool Delete(int id)
        {
            return Newss.Remove(id);
        }
    }
}