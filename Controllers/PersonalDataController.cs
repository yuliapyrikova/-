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
            Storage.PersonalDataStorage.Create(personalData);
            return personalData;
        }

        [HttpGet]
        public PersonalData Read(int personalDataId)
        {
            return Storage.PersonalDataStorage.Read(personalDataId);
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

        [HttpPost("enter-site")]
        public string EnterSite(string str)
        {
            return str;
        }
    }
}