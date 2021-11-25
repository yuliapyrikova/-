using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace pyrikova.Repository
{
    public class SubscriptionStorage
    {
        private readonly Dictionary<int, Subscription> _subscriptions = new();

        public Subscription Create(Subscription subscription)
        {
            // var number = _subscriptions.Keys.Last() + 1;
            var number = _subscriptions.Keys.Max() + 1;
            subscription.Number = number;
            _subscriptions.Add(subscription.Number, subscription);
            return subscription;
            //var command = Subscription.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Subscription Read(int number)
        {
            return _subscriptions[number];
        }

        public Subscription Update(int subscriptionCode, Subscription newSubscription)
        {
            _subscriptions[subscriptionCode] = newSubscription;
            return _subscriptions[subscriptionCode];
        }

        public bool Delete(int number)
        {
            return _subscriptions.Remove(number);
        }
    }
}