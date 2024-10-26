using static System.Net.Mime.MediaTypeNames;

namespace ManageMoney.Domain.Entities
{
    public class Consumption
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Consumption(Guid id, decimal value, string category, string description)
        {
            Id = id;
            Value = value;
            Category = category;
            Date = DateTime.Now;
            Description = description;
        }

        public Consumption(decimal value, string category, string description)
        {
            Value = value;
            Category = category;
            Date = DateTime.Now;
            Description = description;
        }
    }
}
