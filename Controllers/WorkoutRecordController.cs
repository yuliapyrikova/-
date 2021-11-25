using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/workoutRecord")]
    public class WorkoutRecordController : ControllerBase
    {
        [HttpPut]
        public WorkoutRecord Create(WorkoutRecord workoutRecord)
        {
            Storage.WorkoutRecordStorage.Create(workoutRecord);
            return workoutRecord; // Метод создания
        }

        [HttpGet]
        public WorkoutRecord Read(int id)
        {
            return Storage.WorkoutRecordStorage.Read(id); // Метод чтения
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