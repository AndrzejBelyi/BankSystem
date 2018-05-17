using BLL.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public sealed class PlatinumAccount : Account
    {      
        public PlatinumAccount(Person owner, IGenerator generator) : base(owner, generator)
        {
        }

        public PlatinumAccount(Person owner, string number, decimal sum, bool isClosed) : base(owner, number, sum, isClosed)
        {
        }

        protected override void AddBonuses()
        {
            throw new NotImplementedException();
        }

        public override AccountType GetTypeOfAccount()
        {
            return AccountType.Platinum;
        }

        protected override void WithdrawBonuses()
        {
            throw new NotImplementedException();
        }
    }
}
