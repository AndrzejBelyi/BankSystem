using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Interfaces;

namespace BLL.Interface.Entities.Accounts
{
    public abstract class Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="generator">The generator.</param>
        /// <param name="isClosed">if set to <c>true</c> [is closed].</param>
        public Account(Person owner, IGenerateId generator, bool isClosed = false)
        {
            this.Id = generator.Generate();
            this.IsClosed = isClosed;
            this.Owner = owner;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; }

        /// <summary>
        /// Gets the owner.
        /// </summary>
        /// <value>
        /// The owner.
        /// </value>
        public Person Owner { get; }

        /// <summary>
        /// Gets the sum.
        /// </summary>
        /// <value>
        /// The sum.
        /// </value>
        public decimal Sum { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is closed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is closed; otherwise, <c>false</c>.
        /// </value>
        public bool IsClosed { get; private set; }

        /// <summary>
        /// Withdraws the specified sum.
        /// </summary>
        /// <param name="sum">The sum.</param>
        /// <exception cref="System.InvalidOperationException">Account is closed</exception>
        public void Withdraw(decimal sum)
        {
            if (!IsClosed)
            {
                throw new InvalidOperationException("Account is closed");
            }

            WithdrawMoney();
            WithdrawBonuses();
        }

        /// <summary>
        /// Adds the specified sum.
        /// </summary>
        /// <param name="sum">The sum.</param>
        /// <exception cref="System.InvalidOperationException">Account is closed</exception>
        public void Add(decimal sum)
        {
            if(!IsClosed)
            {
                throw new InvalidOperationException("Account is closed");
            }

            AddMoney();
            AddBonuses();
        }

        /// <summary>
        /// Closes this instance.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Account can't be closed</exception>
        public void Close()
        {
            if (!CanBeClosed())
            {
                throw new InvalidOperationException("Account can't be closed");
            }

            IsClosed = true;
        }

        /// <summary>
        /// Determines whether this instance [can be closed].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance [can be closed]; otherwise, <c>false</c>.
        /// </returns>
        protected abstract bool CanBeClosed();

        /// <summary>
        /// Withdraws the bonuses.
        /// </summary>
        protected abstract void WithdrawBonuses();

        /// <summary>
        /// Withdraws the money.
        /// </summary>
        protected abstract void WithdrawMoney();

        /// <summary>
        /// Adds the bonuses.
        /// </summary>
        protected abstract void AddBonuses();

        /// <summary>
        /// Adds the money.
        /// </summary>
        protected abstract void AddMoney();
    }
}
