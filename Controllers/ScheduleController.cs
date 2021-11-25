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
            return schedule; // Метод создания
        }

        [HttpGet]
        public Schedule Read(int id)
        {
            return Storage.ScheduleStorage.Read(id); // Метод чтения
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