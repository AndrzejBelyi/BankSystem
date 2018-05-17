using BLL.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public abstract class Account
    {
        private decimal sum;

        public Account(Person owner, IGenerator generator)
        {
            this.Owner = owner;
            this.Number = generator.GenerateID();
        }

        public Account(Person owner, string number,decimal sum, bool isClosed)
        {
            this.Owner = owner;
            this.Number = number;
            this.Sum = sum;
            this.IsClosed = isClosed;
        }

        public string Number { get; }

        public Person Owner { get; }

        public decimal Sum
        {
            get
            {
                return sum;
            }

            private set
            {
                sum = value;
            }
        }

        public bool IsClosed { get; private set; }

        public virtual decimal lowerLimit { get; } = 0;

 
        public void Withdraw(decimal sum)
        {
            if (IsClosed)
            {
                throw new InvalidOperationException("Account is closed");
            }

            Sum -= sum;
            WithdrawBonuses();
        }

        public void Add(decimal sum)
        {
            if (IsClosed)
            {
                throw new InvalidOperationException("Account is closed");
            }

            Sum += sum;
            AddBonuses();
        }

        public void Close()
        {
            if (!CanBeClosed())
            {
                throw new InvalidOperationException("Account can't be closed");
            }

            IsClosed = true;
        }

        private bool CanBeClosed()
        {
            return Sum == 0;
        }

        protected abstract void WithdrawBonuses();

        protected abstract void AddBonuses();

        public abstract AccountType GetTypeOfAccount();
    }
}
