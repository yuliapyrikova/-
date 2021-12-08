using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class SubscriptionStorage
    {
        private Dictionary<int, Subscription> Subscriptions { get; } = new Dictionary<int, Subscription>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public SubscriptionStorage() => Connection.Open();

        public void Create(Subscription subscription)
        {
            Subscriptions.Add(subscription.SubscriptionNumber, subscription);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Subscription Read(int subscriptionNumber)
        {
            return Subscriptions[subscriptionNumber];
        }

        public Subscription Update(int subscriptionNumber, Subscription newSubscription)
        {
            Subscriptions[subscriptionNumber] = newSubscription;
            return Subscriptions[subscriptionNumber];
        }

        public bool Delete(int subscriptionNumber)
        {
            return Subscriptions.Remove(subscriptionNumber);
        }
    }
}