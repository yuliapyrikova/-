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
            return workoutRecord;
        }

        [HttpGet]
        public WorkoutRecord Read(int workoutRecordId)
        {
            return Storage.WorkoutRecordStorage.Read(workoutRecordId);
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