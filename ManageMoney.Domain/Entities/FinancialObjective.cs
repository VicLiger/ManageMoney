namespace ManageMoney.Domain.Entities
{
    public class FinancialObjective
    {
        public Guid Id { get; private set; }
        public decimal Value { get; private set; }
        public DateTime Date { get; private set; }
        public string Type { get; private set; }


        public FinancialObjective(Guid id, decimal value, string type)
        {
            // Fazer a validação

            Id = id;
            Value = value;
            Date = DateTime.Now;
            Type = type;
        }

        public FinancialObjective( decimal value, string type)
        {
            // Fazer a validação

            Value = value;
            Date = DateTime.Now;
            Type = type;
        }
    }
}
