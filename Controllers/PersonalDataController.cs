using System.Linq;
using System.Threading.Tasks;
using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/personalData")]
    public class PersonalDataController : ControllerBase
    {
        [HttpPut]
        public PersonalData Create(PersonalData personalData)
        {
            Storage.PersonalDataStorage.Create(personalData);
            return news; // Метод создания
        }

        [HttpGet]
        public PersonalData Read(int visitorCode)
        {
            return Storage.PersonalDataStorage.Read(visitorCode); // Метод чтения
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