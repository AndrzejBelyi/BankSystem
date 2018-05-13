using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities.Accounts;
using DAL.Interface;
using DAL.Interface.Interfaces;

namespace DAL.Fake
{
    public class AccountRepository : DAL.Interface.Interfaces.IRepository<Account>
    {
        List<Account> accountList= new List<Account>();

        public AccountRepository()
        {
        }

        public void Add(Account t)
        {
            accountList.Add(t);
        }

        public IEnumerable<Account> GetAll()
        {
           return accountList.AsEnumerable();
        }

        public Account GetById(string id)
        {
            throw new NotImplementedException("there are no realization yet");
        }

        public void Remove(Account t)
        {
            accountList.Remove(t);
        }

        public void Update(Account t)
        {           
        }
    }
}
