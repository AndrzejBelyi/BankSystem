using BLL.Interface.Entities;
using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
   public static class AccountMapper
    {
        public static Account ToBLLAccount (this DTOAccount dtoAccount)
        {
            return AccountFactory.Create(dtoAccount.AccountType, dtoAccount.Person.ToBllPerson(),dtoAccount.Number, dtoAccount.Amount, dtoAccount.IsClosed);
        }

        public static DTOAccount ToDTOAccount(this Account account)
        {
            return new DTOAccount
            {
                Number = account.Number,
                AccountType = account.GetTypeOfAccount(),
                Amount = account.Sum,
                Person = account.Owner.ToDTOPerson(),
                IsClosed = account.IsClosed
            };
        }
    }
}
