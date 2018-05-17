using BLL.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public sealed class BaseAccount : Account
    {      
        public BaseAccount(Person owner, IGenerator generator, bool isClosed = false) : base(owner, generator, isClosed)
        {

        }

        protected override void AddBonuses()
        {
            throw new NotImplementedException();
        }

        protected override void WithdrawBonuses()
        {
            throw new NotImplementedException();
        }
    }
}
