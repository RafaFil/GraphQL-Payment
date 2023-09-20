namespace Program {
    public class Query
    {

        private ICollection<Service> services = new Service[] {
                    new ("1", "Nefli", "Ta one pis", 25),
                    new ("2", "Amazon Plas", "Envio gratis", 2),
                    new ("3", "Warap", "Baki como se usa esto?", 3)
                };
        public ICollection<Service> GetAllServices() =>
            this.services;

        public Service? GetServiceById(int id) 
        {
            var service = services.FirstOrDefault(s => s.Id == id.ToString());
            return service;
        }

        public bool MakePayment(ServicePaymentRequestDTO requestDTO) {

            if(requestDTO == null || requestDTO == null) //aca se vería que la data de pago sea valida y correcta
            {
                return false;
            }

            return true;
        }

        //TODO: NO ANDA BAKI
        public Boolean AddService(Service s ) 
        {
            services.Add(s);
            return true;
        }
    }

    public class ServicePaymentRequestDTO 
    {
        public string FromAccount { get; private set; }
        public double Amount { get; private set; }
        public string PaymentMethod { get; private set; }

        public ServicePaymentRequestDTO(string fromAccount, double amount, string paymentMethod)
        {
            FromAccount = fromAccount;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }
    }
}