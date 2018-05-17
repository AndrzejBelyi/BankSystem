using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using DAL.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BankSystemService : IBankSystemService
    {
        private readonly IUnitOfWork context;
        private readonly IRepository<DAL.Interface.DTO.DTOAccount> accountRepository;
        private readonly IRepository<DAL.Interface.DTO.DTOPerson> personRepository;
        private readonly IGenerator generator;

        public BankSystemService(IRepository<Account> accountRepository,IGenerator generator)
        {
            this.accountRepository = accountRepository;
        }

        public void CreateAccount(AccountType type, Person person, IGenerator generator)
        {
            accountRepository.Add(AccountFactory.Create(type, person, generator));
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
