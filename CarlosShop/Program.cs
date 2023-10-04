using CarlosShop.Entities;
using CarlosShop.Repositories;


RepositoryStock repositoryStock = new();

Stock stock = new();
stock.ProductId = Convert.ToInt32("20"); 
stock.UnitQuantity = Convert.ToInt32("100"); 
stock.UpdatedDate = Convert.ToDateTime("04/10/2023");
stock.CreatedDate = DateTime.Now;

await repositoryStock.Create(stock);