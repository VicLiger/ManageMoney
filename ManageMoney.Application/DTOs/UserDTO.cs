using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMoney.Application.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime CreateDate { get; private set; }

        public Guid AccountCashId { get; private set; }
        public ConsumptionDTO Cash { get; private set; }
    }
}
