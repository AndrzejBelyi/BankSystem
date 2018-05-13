using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Interfaces
{
    public interface IGenerateId
    {
        /// <summary>
        /// Generates this instance.
        /// </summary>
        /// <returns></returns>
        string Generate();
    }
}
