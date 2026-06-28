using RiraTask;

var queryGenerator = new QueryGenerator();
var writer = new Writer();

var products = queryGenerator.RetrieveProductsFromCategory1();
writer.Write("\nRetrieveProductsFromCategory1:");
foreach (var product in products)
{
    writer.WriteProduct(product);
}

var highestProduct = queryGenerator.FindHighestProductByPrice();
writer.Write("\nFindHighestProductByPrice:");
writer.WriteProduct(highestProduct);

var sumOfProductPrices = queryGenerator.GetSumOfProductPrices();
writer.Write("\nsumOfProductPrices:");
writer.Write(sumOfProductPrices);

var groupedProducts = queryGenerator.GroupProductsByCategory();
writer.Write("\nGroupProductsByCategory:");
foreach (var groupedProduct in groupedProducts)
{
    writer.Write(groupedProduct.Key);
    foreach (var product in groupedProduct.Value)
    {
        writer.WriteProduct(product);
    }
}

var averageOfProductPrices = queryGenerator.GetAverageOfProductPrices();
writer.Write("\nGetAverageOfProductPrices:");
writer.Write(averageOfProductPrices);