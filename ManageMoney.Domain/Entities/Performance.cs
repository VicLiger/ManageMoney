﻿namespace ManageMoney.Domain.Entities
{
    public class Performance
    {
        public Guid Id { get; private set; }
        public decimal Value { get; private set; }
        public DateTime Date { get; private set; }
        public string Type { get; private set; }

        // Relações
        public Guid InvestimentId { get; private set; }
        public Investiment Investiment { get; private set; }


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
