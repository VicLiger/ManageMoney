﻿namespace ManageMoney.Domain.Entities
{
    public class FinancialObjective
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }

        public FinancialObjective(Guid id, decimal value, string type)
        {
            Id = id;
            Value = value;
            Date = DateTime.Now;
            Type = type;
        }

        public FinancialObjective(decimal value, string type)
        {
            Value = value;
            Date = DateTime.Now;
            Type = type;
        }
    }
}
