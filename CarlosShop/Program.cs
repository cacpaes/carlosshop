using CarlosShop.Entities;
using CarlosShop.Repositories;

RepositoryCustomer repositoryCustomer = new();
Transactions transaction = new();
List<Sells> sellList = new();

transaction.PersonId = 1;
transaction.TransactionType = "P";
transaction.TransactionDate = DateTime.Now;
transaction.CreatedDate = DateTime.Now;

sellList.Add(new Sells()
{

    ProductId = 1,
    Quantity = 20,
    SellDate = DateTime.Now

});

sellList.Add(new Sells()
{

    ProductId = 5,
    Quantity = 50,
    SellDate = DateTime.Now

});

sellList.Add(new Sells()
{

    ProductId = 10,
    Quantity = 200,
    SellDate = DateTime.Now

});

repositoryCustomer.Purchase(sellList, transaction);