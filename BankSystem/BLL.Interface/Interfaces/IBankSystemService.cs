using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities.Accounts;
using BLL.Interface.Entities;

namespace BLL.Interface.Interfaces
{
    public interface IBankSystemService
    {
        /// <summary>
        /// Creates the account.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="person">The person.</param>
        /// <param name="generator">The generator.</param>
        void CreateAccount(AccountType type, Person person, IGenerateId generator);

        /// <summary>
        /// Closes the specified account.
        /// </summary>
        /// <param name="account">The account.</param>
        void Close(Account account);

        /// <summary>
        /// Adds the specified account.
        /// </summary>
        /// <param name="account">The account.</param>
        /// <param name="sum">The sum.</param>
        void Add(Account account, decimal sum);

        /// <summary>
        /// Withdraws the specified account.
        /// </summary>
        /// <param name="account">The account.</param>
        /// <param name="sum">The sum.</param>
        void Withdraw(Account account, decimal sum);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Account> GetAll();
    }
}
