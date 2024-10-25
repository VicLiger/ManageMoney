﻿
namespace ManageMoney.Application.DTOs
{
    public class ConsumptionDTO
    {
        public Guid Id { get; private set; }
        public decimal Value { get; private set; }
        public string Category { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; }
    }
}