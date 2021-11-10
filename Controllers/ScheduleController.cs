using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/schedule")]
    public class ScheduleController1 : ControllerBase
    {
        [HttpPut]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet]
        public string Read(string str)
        {
            return str;
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

