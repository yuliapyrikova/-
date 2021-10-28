using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{

    [ApiController]
    [Route("/admin")]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        [Route("/admin/Extradite")]

        public string Extradite(string str)
        {
            return "Метод выдачи абонемента";
        }

        [HttpGet]
        [Route("/admin/Extension")]

        public string Extension(string str)
        {
            return "Метод продления абонемента";
        }

        [HttpGet]
        [Route("/admin/Scheduling")]

        public string Scheduling(string str)
        {
            return "Метод составления расписания тренировок";
        }

        [HttpGet]
        [Route("/admin/Requestt")]

        public string Requestt(string str)
        {
            return "Метод запроса отзыва";
        }

        [HttpGet]
        [Route("/admin/NewsFeed")]

        public string NewsFeed(string str)
        {
            return "Метод ведения ленты новостей";
        }
    }
}

