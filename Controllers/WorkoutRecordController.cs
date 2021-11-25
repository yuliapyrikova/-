using System.Linq;
using System.Threading.Tasks;
using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/infAboutTheRec")]
    public class WorkoutRecordController : ControllerBase
    {
        [HttpPut]
        public InfAboutTheRec Create(InfAboutTheRec infAboutTheRec)
        {
            Storage.InfAboutTheRecStorage.Create(infAboutTheRec);
            return infAboutTheRec; // Метод создания
        }

        [HttpGet]
        public InfAboutTheRec Read(int recordCode)
        {
            return Storage.InfAboutTheRecStorage.Read(recordCode); // Метод чтения
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