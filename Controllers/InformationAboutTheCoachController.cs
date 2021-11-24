using System.Linq;
using System.Threading.Tasks;
using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/infAboutTheCoach")]
    public class InfAboutTheCoachController : ControllerBase
    {
        [HttpPut]
        public InfAboutTheCoach Create(InfAboutTheCoach infAboutTheCoach)
        {
            Storage.InfAboutTheCoachStorage.Create(infAboutTheCoach);
            return infAboutTheCoach; // Метод создания
        }

        [HttpGet]
        public InfAboutTheCoach Read(int trainerCode)
        {
            return Storage.InfAboutTheCoachStorage.Read(trainerCode); // Метод чтения
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