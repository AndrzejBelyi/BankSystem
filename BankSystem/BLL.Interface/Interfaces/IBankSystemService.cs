using BLL.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Interfaces
{
    public interface IBankSystemService
    {
        void CreateAccount(AccountType type, Person person, IGenerator generator);

        void Close(Account account);

        void Add(Account account, decimal sum);

        void Withdraw(Account account, decimal sum);

        IEnumerable<Account> GetAll();
    }
}
