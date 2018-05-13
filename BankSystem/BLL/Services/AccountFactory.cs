using BLL.Interface.Entities;
using BLL.Interface.Entities.Accounts;
using BLL.Interface.Interfaces;

namespace BLL.Services
{
    public static class AccountFactory
    {
        public static Account Create(AccountType type, Person owner,IGenerateId generator)
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
