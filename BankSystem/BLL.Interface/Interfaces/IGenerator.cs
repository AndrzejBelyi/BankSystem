﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Interfaces
{
    public interface IGenerator
    {
        /// <summary>
        /// Generates the ID.
        /// </summary>
        /// <returns></returns>
        string GenerateID();
    }
}
