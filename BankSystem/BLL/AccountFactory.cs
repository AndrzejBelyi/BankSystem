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
        public static Account Create(AccountType type, Person owner, IGenerator generator)
        {
            Account newAccount = null;

            switch (type)
            {
                case AccountType.Base:
                    newAccount = new BaseAccount(owner, generator);
                    break;
                case AccountType.Gold:
                    newAccount = new GoldAccount(owner, generator);
                    break;
                case AccountType.Platinum:
                    newAccount = new PlatinumAccount(owner, generator);
                    break;
            }

            return newAccount;
        }
    }
}
