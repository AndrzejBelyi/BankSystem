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
    class BankSystemService: IBankSystemService
    {
        private IRepository<Account> repository;

        private IAccountFactory accountFactory;
        
        public BankSystemService(IRepository<Account> repository, IAccountFactory accountFactory)
        {
            this.repository = repository;
            this.accountFactory = accountFactory;
        }

        public void CreateAccount(AccountType type, Person person, IGenerateId generator)
        {           
            repository.Add(accountFactory.Create(type, person, generator));
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
    }
}
