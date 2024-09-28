namespace ManageMoney.Domain.Entities
{
    public class Investiment
    {
        public Guid Id { get; private set; }
        public string Type { get; private set; }
        public decimal Value { get; private set; }
        public DateTime Date { get; private set; }

        public Guid PerfomanceId { get; private set; }
        public Performance Performance { get; private set; }

        public Investiment(Guid id, decimal value, string type)
        {
            // Fazer a validação

            Id = id;
            Type = type;
            Value = value;
            Date = DateTime.Now;
        }

        public Investiment(decimal value, string type)
        {
            // Fazer a validação

            Type = type;
            Value = value;
            Date = DateTime.Now;
        }
    }
}
