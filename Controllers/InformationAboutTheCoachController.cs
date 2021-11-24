using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
 
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
}

