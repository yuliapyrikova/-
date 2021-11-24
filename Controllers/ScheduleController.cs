using System.Linq;
using System.Threading.Tasks;
using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
            return schedule; // Метод создания
        }

        [HttpGet]
        public Schedule Read(int scheduleCode)
        {
            return Storage.ScheduleStorage.Read(scheduleCode); // Метод чтения
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