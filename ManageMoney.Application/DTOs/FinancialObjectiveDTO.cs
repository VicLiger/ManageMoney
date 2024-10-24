﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMoney.Application.DTOs
{
    public class FinancialObjectiveDTO
    {
        public Guid Id { get; private set; }
        public decimal Value { get; private set; }
        public DateTime Date { get; private set; }
        public string Type { get; private set; }
    }
}
