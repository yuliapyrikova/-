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
            return Storage.CoachStorage.Create(coach);
        }

        [HttpGet]
        public Coach Read(int coachId)
        {
            return Storage.CoachStorage.Read(coachId);
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

        [HttpDelete]
        public string EnterAccount(string str)
        {
            return str; // Метод входа в личный кабинет
        }
    }
}