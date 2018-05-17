using ORM;
using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
   public static class PersonMapper
    {
        public static Person ToORMPerson(this DTOPerson person)
        {
            var ormPerson = new Person
            {
                FirstName = person.FirstName,
                LastName = person.LastName,                
                Email = person.Email
            };

            foreach (var i in person.Accounts)
            {
                ormPerson.Accounts.Add(i.ToORMAccount());
            }

            return ormPerson;
        }

        public static DTOPerson ToDTOPerson(this Person person)
        {
            var dtoPerson = new DTOPerson
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Email = person.Email
            };

            foreach (var i in person.Accounts)
            {
                dtoPerson.Accounts.Add(i.ToDTOAccount());
            }

            return dtoPerson;
        }
    }
}
