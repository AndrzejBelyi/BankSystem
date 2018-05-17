using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class AccountFactory
    {
        public static Account Create(AccountType type, Person owner, string number, decimal sum, bool isClosed)
        {
            Account newAccount = null;

            switch (type)
            {
                case AccountType.Base:
                    newAccount = new BaseAccount(owner, number, sum, isClosed);
                    break;
                case AccountType.Gold:
                    newAccount = new GoldAccount(owner, number, sum, isClosed);
                    break;
                case AccountType.Platinum:
                    newAccount = new PlatinumAccount(owner, number, sum, isClosed);
                    break;
            }

            return newAccount;

        }
    }
}
