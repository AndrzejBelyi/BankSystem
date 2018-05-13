using BLL.Interface.Entities;
using BLL.Interface.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Interfaces
{
    public interface IAccountFactory
    {
        /// <summary>
        /// Creates the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="generator">The generator.</param>
        /// <returns></returns>
        Account Create(AccountType type, Person owner,IGenerateId generator);
    }
}
