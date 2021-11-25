using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/personalData")]
    public class PersonalDataController : ControllerBase
    {
        [HttpPut]
        public PersonalData Create(PersonalData personalData)
        {
            return Storage.PersonalDataStorage.Create(personalData);
        }

        [HttpGet]
        public PersonalData Read(int id)
        {
            return Storage.PersonalDataStorage.Read(id); // Метод чтения
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

        [HttpGet]
        public string EnterSite(string str)
        {
            return str; // Метод входа на сайт
        }
    }
}