using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/infAboutTheCoach")]
    public class CoachController : ControllerBase
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

        [HttpDelete]
        public string EnterAccount(string str)
        {
            return str; // Метод входа в личный кабинет
        }
    }
}