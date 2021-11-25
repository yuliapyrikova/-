using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/coach")]
    public class CoachController : ControllerBase
    {
        [HttpPut]
        public Coach Create(Coach coach)
        {
            Storage.CoachStorage.Create(Coach);
            return Coach; // Метод создания
        }

        [HttpGet]
        public Coach Read(int id)
        {
            return Storage.InfAboutTheCoachStorage.Read(id); // Метод чтения
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