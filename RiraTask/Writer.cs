namespace RiraTask;

public class Writer
{
    public void Write(object data)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(data);
    }

    public void WriteProduct(Product product)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{product.Id} {product.Name} {product.Category} {product.Price}");
    }
}