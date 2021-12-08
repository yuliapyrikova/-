using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/schedule")]
    public class ScheduleController : ControllerBase
    {
        [HttpPut]
        public Schedule Create(Schedule schedule)
        {
            Storage.ScheduleStorage.Create(schedule);
            return schedule;
        }

        [HttpGet]
        public Schedule Read(int scheduleId)
        {
            return Storage.ScheduleStorage.Read(scheduleId);
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