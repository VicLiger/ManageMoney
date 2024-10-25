namespace ManageMoney.Domain.Entities
{
    public class Performance
    {
        public Guid Id { get;  set; }
        public decimal Value { get;  set; }
        public DateTime Date { get;  set; }
        public string Type { get;  set; }

        // Relações
        public Guid InvestimentId { get;  set; }
        public Investiment Investiment { get;  set; }


        public Performance(Guid id, decimal value, string type)
        {

            // Fazer a validação

            Id = id;
            Value = value;
            Date = DateTime.Now;
            Type = type;
        }

        public Performance(decimal value, string type)
        {
            // Fazer a validação

            Value = value;
            Date = DateTime.Now;
            Type = type;
        }
    }
}
