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
        public WorkoutRecord Update(int workoutRecordId, WorkoutRecord newWorkoutRecord)
        {
            return Storage.WorkoutRecordStorage.Update(workoutRecordId, newWorkoutRecord);
        }
    }
}