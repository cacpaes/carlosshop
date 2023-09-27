using CarlosShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop.Repositories
{
    public class RepositoryProduct
    {
        public void Create(Product productEntry)
        {
            var product = new Product();

            product.Id = productEntry.Id;
            product.Name = productEntry.Name;
            product.Type = productEntry.Type;
            product.Weight = productEntry.Weight;
            product.Height = productEntry.Height;
            product.Width = productEntry.Width;
            product.Depth = productEntry.Depth;
            product.PurchaseValue = productEntry.PurchaseValue;
            product.SaleValue = productEntry.SaleValue;
            product.PurchaseVatRate = productEntry.PurchaseVatRate;
            product.SaleVatRate = productEntry.SaleVatRate;

            Console.WriteLine(product.Id);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Type);
            Console.WriteLine(product.Weight);
            Console.WriteLine(product.Height);
            Console.WriteLine(product.Width);
            Console.WriteLine(product.Depth);
            Console.WriteLine(product.PurchaseValue);
            Console.WriteLine(product.SaleValue);
            Console.WriteLine(product.PurchaseVatRate);
            Console.WriteLine(product.SaleVatRate);
        }
    }
}
