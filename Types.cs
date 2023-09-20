namespace Program {

    public class Service
    {
        public string Id { get;  set; }
        public string Name { get;  set; }
        public string Description { get;  set; }
        public float MonthlyFee { get;  set; }

        public Service() {
            
        }
        // public Service(string name, string description, float monthlyFee)
        // {
        //     Name = name;
        //     Description = description;
        //     MonthlyFee = monthlyFee;
        // }

        // public Service(string id, string name, string description, float monthlyFee) : this(name, description, monthlyFee)
        // {
        //     Id = id;
        // }

    }

    public class Payment
    {
        public string PaymentId { get;  set; }
        public string ReceiptId { get;  set; }
        public string EmitterId { get;  set; }
        public Service Service { get;  set; }
    }

    public class Subscription
    {
        public string ServiceId { get;  set; }
        public string UserId { get;  set; }
        public string SubscriptionId { get;  set; }
        public double CurrentDebt { get;  set; }

    }

    public class User
    {
        public string UserId { get;  set; }

        public string Name { get;  set; }
        public string AccountName { get;  set; }
        public float MonthlyFee { get;  set; }

    }
}