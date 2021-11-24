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
}