namespace ManageMoney.Domain.Entities
{
    public class Investiment
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }

        public Investiment(Guid id, decimal value, string type)
        {
            Id = id;
            Type = type;
            Value = value;
            Date = DateTime.Now;
        }

        public Investiment(decimal value, string type)
        {
            Type = type;
            Value = value;
            Date = DateTime.Now;
        }
    }
}
