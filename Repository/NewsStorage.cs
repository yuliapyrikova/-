using pyrikova.Domain;
using System.Collections.Generic;
using System.Linq;

namespace pyrikova.Repository
{
    public class NewsStorage
    {
        private readonly Dictionary<int, News> _newsStorage = new();
        
        public News Create(News news)
        {
            // var id = _newss.Keys.Last() + 1;
            var id = _newsStorage.Keys.Max() + 1;
            news.Id = id;
            _newsStorage.Add(news.Id, news);
            return news;
            //var command = News.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public News Read(int id)
        {
            return _newsStorage[id];
        }

        public News Update(int id, News newNews)
        {
            _newsStorage[id] = newNews;
            return _newsStorage[id];
        }

        public bool Delete(int id)
        {
            return _newsStorage.Remove(id);
        }
    }
}