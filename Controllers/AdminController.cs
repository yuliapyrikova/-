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
            return admin;
        }

        [HttpGet]
        public Admin Read(int adminId)
        {
            return Storage.AdminStorage.Read(adminId);
        }

        [HttpPost]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }

        [HttpGet("get-shedule")]
        public string Scheduling(string str)
        {
            return str; // Метод составления расписания
        }

        [HttpGet("request-feedback")]
        public string RequestForFeedback(string str)
        {
            return str; // Метод запроса отзыва
        }

        [HttpPost("create-news")]
        public string CreateNews(string str)
        {
            return str; // Метод создания ленты новостей
        }
    }
}