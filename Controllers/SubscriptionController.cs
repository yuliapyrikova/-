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
            return subscription;
        }

        [HttpGet]
        public Subscription Read(int subscriptionNumber)
        {
            return Storage.SubscriptionStorage.Read(subscriptionNumber);
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
    }
}