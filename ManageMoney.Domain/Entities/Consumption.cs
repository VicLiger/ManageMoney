using static System.Net.Mime.MediaTypeNames;

namespace ManageMoney.Domain.Entities
{
    public class Consumption
    {
        public Guid Id { get; private set; }
        public decimal Value { get; private set; }
        public string Category { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; }

        public Consumption(Guid id, decimal value, string category, string description)
        {
            // Fazer a validação

            Id = id;
            Value = value;
            Category = category;
            Date = DateTime.Now;
            Description = description;
        }

        public Consumption( decimal value, string category, string description)
        {
            // Fazer a validação

            Value = value;
            Category = category;
            Date = DateTime.Now;
            Description = description;
        }

    }
}
