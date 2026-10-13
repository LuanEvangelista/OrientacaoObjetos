
using OrientacaoObjetos.NotificactionContext;
using OrientacaoObjetos.sharedContext;

namespace OrientacaoObjetos.SubscriptionContext
{
    public class Student : Base
    {
        public Student(string name, string email, User user)
        {
            Name = name;
            Email = email;
            User = user;
            subscriptions = new List<Subscription>();
        }

        public Student()
        {
            subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }


        public List<Subscription> subscriptions { get; set; }

        public bool IsPremium => subscriptions.Any(x => x.IsActive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Student.Subscriptions", "Você já possui uma assinatura ativa."));
                return;

            }

            subscriptions.Add(subscription);
        }

    }
}