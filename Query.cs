
namespace Program
{
    public class Query
    {
        private ICollection<Service> services = new Service[] {
                    new ("1", "Nefli", "Ta one pis", 25),
                    new ("2", "Amazon Plas", "Envio gratis", 2),
                    new ("3", "Warap", "Baki como se usa esto?", 3)
                };

        private Dictionary<User, ICollection<Subscription>> mockSubData = new()
        {
            {new User("1", "leo", "ahorroArg", 50),
                new List<Subscription>(){ (new Subscription("1","a","1",123)),
                (new Subscription("2","b","1",123)) ,
                (new Subscription("3","c","1",123))} },
            {new User("2", "Ryan", "goslings", 504),
                new List<Subscription>(){ (new Subscription("3","d", "321",12)),
                (new Subscription("4","e","321",123))} }
        };
        public ICollection<Service> GetAllServices() =>
            this.services;

        public Service? GetServiceById(int id)
        {
            var service = services.FirstOrDefault(s => s.Id == id.ToString());
            return service;
        }

        public ICollection<User> GetAllUsers() =>
            this.mockSubData.Keys;


        public ICollection<Subscription> GetSubscriptionsByUser(User user) =>
            this.mockSubData[user];

        public User? GetUserById(int id)
        {
            var user = mockSubData.Keys.FirstOrDefault(u => u.UserId == id.ToString());
            return user;
        }

    }

}