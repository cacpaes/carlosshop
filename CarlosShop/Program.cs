using CarlosShop.Entities;
using CarlosShop.Repositories;


RepositoryProduct repositoryProduct = new();

Product product = new();
product.ProductName = "CoCa CoLa 1L";
product.ProductWeight = Convert.ToDecimal("1"); // Peso do Produto
product.ProductHeight = Convert.ToDecimal("30"); // Altura do Produto
product.ProductWidth = Convert.ToDecimal("10"); // Largura do produto
product.ProductDepth = Convert.ToDecimal("30"); // Profundidade do produto
product.PurchaseValue = Convert.ToDecimal("1"); // Valor de compra
product.SaleValue = Convert.ToDecimal("2"); // Valor de venda
product.PurchaseVatRate = Convert.ToDecimal("20"); // Taxa de IVA de compra
product.PersonType = "P";
product.SaleVatRate = Convert.ToDecimal("20"); // Taxa de vendaVat
product.UpdatedDate = Convert.ToDateTime("04/10/2023");
product.CreatedDate = DateTime.Now;

await repositoryProduct.Create(product);