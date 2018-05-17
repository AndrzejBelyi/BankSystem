using BLL.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GeneratorID : IGenerator
    {
        public string GenerateID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
