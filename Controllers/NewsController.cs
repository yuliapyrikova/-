using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/news")]
    public class NewsController : ControllerBase
    {
        [HttpPut]
        public News Create(News news)
        {
            Storage.NewsStorage.Create(news);
            return news;
        }

        [HttpGet]
        public News Read(int newsId)
        {
            return Storage.NewsStorage.Read(newsId);
        }

        [HttpPatch]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }
    }
}