using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Interfaces;

namespace BLL.Interface.Entities.Accounts
{
    public sealed class PlatinumAccount : Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatinumAccount"/> class.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="generator">The generator.</param>
        /// <param name="isClosed">if set to <c>true</c> [is closed].</param>
        public PlatinumAccount(Person owner, IGenerateId generator, bool isClosed = false) : base(owner, generator, isClosed)
        {
        }

        protected override void AddBonuses()
        {
            throw new NotImplementedException();
        }

        protected override void AddMoney()
        {
            throw new NotImplementedException();
        }

        protected override bool CanBeClosed()
        {
            throw new NotImplementedException();
        }

        protected override void WithdrawBonuses()
        {
            throw new NotImplementedException();
        }

        protected override void WithdrawMoney()
        {
            throw new NotImplementedException();
        }
    }
}
