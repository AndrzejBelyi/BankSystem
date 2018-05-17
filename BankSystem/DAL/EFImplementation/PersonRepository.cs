using DAL.Interface.DTO;
using DAL.Interface.Interfaces;
using ORM;
using System;
using System.Collections.Generic;

namespace DAL.EFImplementation
{
    class PersonRepository : IRepository<DTOPerson>
    {
        BankSystemDataBaseEntities context;

        public PersonRepository(BankSystemDataBaseEntities context)
        {
            this.context = context;
        }

        public void Add(DTOPerson entity)
        {
            if (ReferenceEquals(entity, null))
            {
                throw new ArgumentNullException($"{nameof(entity)} is null");
            }

            Person temp = new Person()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email
            };

            context.Persons.Add(temp);
        }

        public IEnumerable<DTOPerson> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(DTOPerson entity)
        {
            throw new NotImplementedException();
        }

        public void Update(DTOPerson entity)
        {
            throw new NotImplementedException();
        }
    }
}
