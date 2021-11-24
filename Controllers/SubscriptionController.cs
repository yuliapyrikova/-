using System.Linq;
using System.Threading.Tasks;
using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        public Subscription Read(int subscriptionNumber)
        {
            return Storage.SubscriptionStorage.Read(subscriptionNumber); // Метод чтения
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