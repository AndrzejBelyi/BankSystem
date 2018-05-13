using BLL.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GenerateID : IGenerateId
    {
        public string Generate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
