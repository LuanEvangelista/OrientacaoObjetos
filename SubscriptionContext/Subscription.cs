using OrientacaoObjetos.sharedContext;

namespace OrientacaoObjetos.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsActive => EndDate == null || EndDate > DateTime.Now;
    }
}