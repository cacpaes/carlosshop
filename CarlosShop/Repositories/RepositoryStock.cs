using CarlosShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop.Repositories
{
    public class RepositoryStock
    {
        public void Create(Stock stockEntry)
        {
            var stock = new Stock();

            stock.Id = stockEntry.Id;
            stock.ProductId = stockEntry.ProductId;
            stock.UnitQuantity = stockEntry.UnitQuantity;

            Console.WriteLine(stock.Id);
            Console.WriteLine(stock.ProductId);
            Console.WriteLine(stock.UnitQuantity);
        }
    }
         
}
