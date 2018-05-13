using BLL.Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Fake1
{
    public class PersonRepository : DAL.Interface.Interfaces.IRepository<Person>
    {
        List<Person> personList = new List<Person>();

        public PersonRepository()
        {
        }

        public void Add(Person t)
        {
            personList.Add(t);
        }

        public IEnumerable<Person> GetAll()
        {
            return personList.AsEnumerable();
        }

        public Person GetById(string id)
        {
            throw new NotImplementedException("there are no realization yet");
        }

        public void Remove(Person t)
        {
            personList.Remove(t);
        }

        public void Update(Person t)
        {
        }
    }
}
