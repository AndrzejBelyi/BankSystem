using System;
using System.Collections.Generic;
using DAL.Interface.DTO;
using DAL.Interface.Interfaces;
using ORM;

namespace DAL.EFImplementation
{
    class AccountRepository : IRepository<DTOAccount>
    {
        BankSystemDataBaseEntities context;

        public AccountRepository(BankSystemDataBaseEntities context)
        {
            this.context = context;
        }

        public void Add(DTOAccount entity)
        {
            if (ReferenceEquals(entity, null))
            {
                throw new ArgumentNullException($"{nameof(entity)} is null");
            }

            Account temp = new Account()
            {
                Account_number = entity.Number,
                AccountType = entity.AccountType.ToString(),             
                Amount = entity.Amount,
                Id = entity.Id,
                IsClosed = entity.IsClosed,
                Person = entity.Person,

            };


        }

        public IEnumerable<DTOAccount> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(DTOAccount entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(DTOAccount entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
