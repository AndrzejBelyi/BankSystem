using BLL.Interface.Entities;
using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
   public static class PersonMapper
    {
        public static DTOPerson ToDTOPerson(this Person person)
        {
            var dtoPerson = new DTOPerson
            {
                FirstName = person.FirstName,
                LastName = person.LastName,                
                Email = person.Email
            };

            foreach (var i in person.accounts)
            {
                dtoPerson.Accounts.Add(i.ToDTOAccount());
            }

            return dtoPerson;
        }

        public static Person ToBllPerson(this DTOPerson dtoPerson)
        {
            var person = new Person(dtoPerson.FirstName, dtoPerson.LastName, dtoPerson.Email);
            foreach(var i in dtoPerson.Accounts)
            {
                person.accounts.Add(i.ToBLLAccount());
            }

            return person;
        }
    }
}
