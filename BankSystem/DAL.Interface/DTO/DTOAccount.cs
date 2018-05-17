using BLL.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class DTOAccount
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public AccountType AccountType { get; set; }

        public decimal Amount { get; set;}

        public bool IsClosed { get; set; }

        public DTOPerson Person { get; set; }
    }
}
