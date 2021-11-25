using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/subscription")]
    public class SubscriptionController : ControllerBase
    {
        [HttpPut]
        public Subscription Create(Subscription subscription)
        {
            Storage.SubscriptionStorage.Create(subscription);
            return subscription; // Метод создания
        }

        [HttpGet]
        public Subscription Read(int number)
        {
            return Storage.SubscriptionStorage.Read(number); // Метод чтения
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