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
            return news; // Метод создания
        }

        [HttpGet]
        public News Read(int id)
        {
            return Storage.NewsStorage.Read(id); // Метод чтения
        }

        [HttpPatch]
        public string Update(string str)
        {
            return str; // Метод обновления
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str; // Метод удаления
        }
    }
}