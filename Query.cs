namespace Program {
    public class Query
    {
        public Service GetServices() =>
            new()
            {
                Id = "1",
                Name = "Servicio",
                Description = "no anda el grafico",
                MonthlyFee = 5
            };

        
    }
}