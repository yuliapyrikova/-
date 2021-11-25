using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/admin")]
    public class AdminController : ControllerBase
    {
        [HttpPut]
        public Admin Create(Admin admin)
        {
            Storage.AdminStorage.Create(admin);
            return admin; // Метод создания
        }

        [HttpGet]
        public Admin Read(int adminCode)
        {
            return Storage.AdminStorage.Read(adminCode); // Метод чтения
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

        [HttpGet]
        public string Scheduling(string str)
        {
            return str; // Метод составления расписания
        }

        [HttpGet]
        public string RequestForFeedback(string str)
        {
            return str; // Метод запроса отзыва
        }

        [HttpGet]
        public string Management(string str)
        {
            return str; // Метод управления абонементами
        }

        [HttpGet]
        public string CreatingNews(string str)
        {
            return str; // Метод создания ленты новостей
        }
    }
}