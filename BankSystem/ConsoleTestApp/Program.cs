using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;
using BLL.Interface.Entities.Accounts;
using BLL.Interface.Interfaces;
using DAL.Interface.Interfaces;
using DependencyResolver;
using Ninject;


namespace ConsoleTestApp
{
    class Program
    {
        private static readonly IKernel resolver;

        static Program()
        {
            resolver = new StandardKernel();
            resolver.ConfigurateResolver();
        }

        static void Main(string[] args)
        {
            IBankSystemService service = resolver.Get<IBankSystemService>();
            IGenerateId creatorId = resolver.Get<IGenerateId>();

            Person p1 = new Person("Вася", "Пупкин", "email_1");
            Person p2 = new Person("Name_2", "Name_2", "email_2");
            Person p3 = new Person("Name_3", "Name_3", "email_3");
            Person p4 = new Person("Вася", "Пупкин", "email_4");

            service.CreateAccount(AccountType.Base, p1, creatorId);
            service.CreateAccount(AccountType.Base, p2, creatorId);
            service.CreateAccount(AccountType.Base, p3, creatorId);
            service.CreateAccount(AccountType.Base, p4, creatorId);
            service.CreateAccount(AccountType.Base, p2, creatorId);
            service.CreateAccount(AccountType.Base, p1, creatorId);

            var accounts = service.GetAll();

            foreach(var i in accounts)
            {
                Console.WriteLine("Счёт : " + i.Id);
                Console.WriteLine("Cумма : " + i.Sum);
                Console.WriteLine("Владелец : ");
                Console.WriteLine(" "+ i.Owner.FirstName);
                Console.WriteLine(" " + i.Owner.LastName);
                Console.WriteLine(" " + i.Owner.Email);

            }

        }
    }
}
