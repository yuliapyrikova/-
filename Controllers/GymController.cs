using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace pyrikova.Controllers
{
            [ApiController]
            [Route("[/visitor]")]
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
  

            [ApiController]
            [Route("[/coach]")]
            public class CoachController : ControllerBase
            {
            [HttpPut]
            [Route("/coach/FollowTheSchedule")]

            public string FollowTheSchedule(string str)
            {
                return "Метод наблюдения за собственным расписанием";
            }

            [HttpPut]
            [Route("/coach/VisitorInformation")]

            public string VisitorInformation(string str)
            {
                return "Метод просматривания информации о записавшемся";
            }


            [ApiController]
            [Route("[/admin]")]
            public class AdminController : ControllerBase
            {
            [HttpPost]
            [Route("/admin/Extradite")]

            public string Extradite(string str)
            {
                    return "Метод выдачи абонемента";
            }

            [HttpPost]
            [Route("/admin/Extension")]

            public string Extension(string str)
            {
                    return "Метод продления абонемента";
            }

            [HttpPost]
            [Route("/admin/Scheduling")]

            public string Scheduling(string str)
            {
                    return "Метод составления расписания тренировок";
            }

            [HttpPost]
            [Route("/admin/Request")]

            public string Request(string str)
            {
                    return "Метод запроса отзыва";
            }

            [HttpPost]
            [Route("/admin/NewsFeed")]

            public string NewsFeed(string str)
            {
                    return "Метод ведения ленты новостей";
            }

            }
        }
    }
}
