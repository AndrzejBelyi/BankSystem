using BLL.Interface.Entities.Accounts;
using BLL.Interface.Interfaces;
using BLL.Services;
using DAL.Fake;
using DAL.Interface.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolver(this IKernel kernel)
        {
            kernel.Bind<IBankSystemService>().To<BankSystemService>();
            kernel.Bind<IRepository<Account>>().To<AccountFakeRepository>();
            kernel.Bind<IGenerateId>().To<GenerateID>().InSingletonScope();    
            
        }
    }
}
