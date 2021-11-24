using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public class SubscriptionStorage2
    {
        private Dictionary<int, Subscription> Subscriptions { get; } = new Dictionary<int, Subscription>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public SubscriptionStorage2() => Connection.Open();

        public void Create(Subscription subscription)
        {
            Subscriptions.Add(subscription.SubscriptionCode, subscription);
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

        public Subscription Update(int subscriptionCode, Subscription newSubscription)
        {
            Subscriptions[subscriptionCode] = newSubscription;
            return Subscriptions[subscriptionNumber];
        }

        public bool Delete(int subscriptionNumber)
        {
            return Subscriptions.Remove(subscriptionNumber);
        }
    }
}