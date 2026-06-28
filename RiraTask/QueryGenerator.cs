namespace RiraTask;

public class QueryGenerator
{
    private readonly List<Product> _products = ProductDataGroup.GetProducts();

    public List<Product> RetrieveProductsFromCategory1()
    {
        var selectedProducts = _products.Where(p => p.Category == Categories.Category1).ToList();
        return selectedProducts;
    }

    public Product FindHighestProductByPrice()
    {
        var selectedProduct = _products.OrderByDescending(p => p.Price).First();;
        return selectedProduct;
    }

    public int GetSumOfProductPrices()
    {
        var sumOfPrices = _products.Sum(p => p.Price);
        return sumOfPrices;
    }

    public Dictionary<Categories, List<Product>> GroupProductsByCategory()
    {
        var groupedProducts = _products.GroupBy(p => p.Category).ToDictionary(g => g.Key, g => g.ToList());
        return groupedProducts;
    }

    public double GetAverageOfProductPrices()
    {
        var sumOfPrices = _products.Average(p => p.Price);
        return sumOfPrices;
    }
}