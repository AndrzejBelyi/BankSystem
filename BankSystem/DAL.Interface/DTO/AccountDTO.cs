using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    class AccountDTO
    {
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
        public PersonDTO Owner { get; }

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
    }
}
