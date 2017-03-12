using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiiPractic.Data.Entities;
using FiiPractic.Data.Infrastructure;
using FiiPractic.Services.Infrastructure;

namespace FiiPractic.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {

            System.Console.WriteLine("test");

            var factory = new DatabaseFactory();

            var repo = new Repository<Product>(factory);
            var uow = new UnitOfWork(factory);

            var baseService = new BaseService<Product>(repo, uow);

            

            baseService.Get(p => p.Name.StartsWith("S"));

            foreach(var product in baseService.Get(p => p.Price > 42)){
                System.Console.WriteLine(product.Name);
            }

        }
    }
}
