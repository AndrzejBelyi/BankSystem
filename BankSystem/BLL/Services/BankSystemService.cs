using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;
using BLL.Interface.Entities.Accounts;
using BLL.Interface.Interfaces;
using DAL.Interface.Interfaces;

namespace BLL.Services
{
    public class BankSystemService: IBankSystemService
    {
        private IRepository<Account> repository;
        
        public BankSystemService(IRepository<Account> repository)
        {
            this.repository = repository;
        }

        public void CreateAccount(AccountType type, Person person, IGenerateId generator)
        {           
            repository.Add(AccountFactory.Create(type, person, generator));
        }

        public void Add(Account account, decimal sum)
        {
            account.Add(sum);
        }

        public void Close(Account account)
        {
            account.Close();
        }

        public void Withdraw(Account account, decimal sum)
        {
            account.Withdraw(sum);
        }

        public IEnumerable<Account> GetAll()
        {
           return repository.GetAll();
        }
    }
}
