using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/visitor")]
    public class VisitorController : ControllerBase
    {
        [HttpGet]
        [Route("/visitor/MonitorsTheSubscription")]

        public string MonitorsTheSubscription(string str)
        {
            return "Метод наблюдения за абонементом";
        }

        [HttpGet]
        [Route("/visitor/Record")]
        public string Record(string str)
        {
            return "Метод записи на тренировку";
        }

        [HttpGet]
        [Route("/visitor/Feedback")]

        public string Feedback(string str)
        {
            return "Метод написания отзыва";
        }
    }
    [ApiController]
    [Route("/coach")]
    public class CoachController : ControllerBase
    {
        [HttpGet]
        [Route("/coach/FollowTheSchedule")]

        public string FollowTheSchedule(string str)
        {
            return "Метод наблюдения за собственным расписанием";
        }

        [HttpGet]
        [Route("/coach/VisitorInformation")]

        public string VisitorInformation(string str)
        {
            return "Метод просматривания информации о записавшемся";
        }
    }

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

