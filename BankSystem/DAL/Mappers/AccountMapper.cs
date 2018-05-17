using ORM;
using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
   public static class AccountMapper
    {
        public static Account ToORMAccount(this DTOAccount dtoAccount)
        {
            var account = new Account
            {
                Id = dtoAccount.Id,
                Account_number = dtoAccount.Number,
                AccountType = dtoAccount.AccountType.ToString(),
                Amount = dtoAccount.Amount,
                Person = dtoAccount.Person.ToORMPerson(),
                IsClosed = dtoAccount.IsClosed
            };

            return account;
        }

        public static DTOAccount ToDTOAccount(this Account account)
        {
            var dtoAccount = new DTOAccount
            {
                Id = account.Id,
                Number = account.Account_number,
                ///////ATTENTION////////////////
                AccountType = BLL.Interface.Entities.AccountType.Base,
                ///////////////////////////////
                Amount = account.Amount,
                Person = account.Person.ToDTOPerson(),
                IsClosed = account.IsClosed
            };

            return dtoAccount;
        }
    }
}
