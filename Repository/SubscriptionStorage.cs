using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class SubscriptionStorage
    {
        private readonly Dictionary<int, Subscription> _Subscriptions = new();

        public WorkoutRecord Create(Subscription subscription)
        {
            // var number = _subscriptions.Keys.Last() + 1;
            var number = _subscriptions.Keys.Max() + 1;
            subscription.Number = id;
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
            return Subscriptions[number];
        }

        public Subscription Update(int subscriptionCode, Subscription newSubscription)
        {
            Subscriptions[number] = newSubscription;
            return Subscriptions[number];
        }

        public bool Delete(int number)
        {
            return Subscriptions.Remove(number);
        }
    }
}