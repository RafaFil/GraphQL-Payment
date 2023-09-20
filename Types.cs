namespace Program
{

    public class Service
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float MonthlyFee { get; set; }

        public Service(string name, string description, float monthlyFee)
        {
            this.Name = name;
            this.Description = description;
            this.MonthlyFee = monthlyFee;
        }

        public Service(string id, string name, string description, float monthlyFee) : this(name, description, monthlyFee)
        {
            this.Id = id;
        }

    }

    public class Payment
    {
        public string PaymentId { get; set; }
        public string ReceiptId { get; set; }
        public string EmitterId { get; set; }
        public Service Service { get; set; }
    }

    public class Subscription
    {
        public string ServiceId { get; set; }
        public string UserId { get; set; }
        public string SubscriptionId { get; set; }
        public double CurrentDebt { get; set; }

        public Subscription(string serviceId, string userId, double currentDebt)
        {
            ServiceId = serviceId;
            UserId = userId;
            CurrentDebt = currentDebt;
        }

        public Subscription(string subscriptionId, string serviceId, string userId, double currentDebt) : this(serviceId, userId, currentDebt)
        {
            SubscriptionId = subscriptionId;
        }
    }

    public class User
    {
        public string UserId { get; set; }

        public string Name { get; set; }
        public string AccountName { get; set; }
        public float MonthlyFee { get; set; }

        public User(string userId, string name, string accountName, float monthlyFee)
        {
            this.UserId = userId;
            this.Name = name;
            this.AccountName = accountName;
            this.MonthlyFee = monthlyFee;
        }

        // public User(string userId, string name, string accountName, float monthlyFee)
        // {
        //     UserId = userId;
        //     Name = name;
        //     AccountName = accountName;
        //     MonthlyFee = monthlyFee;
        // }
    }
}