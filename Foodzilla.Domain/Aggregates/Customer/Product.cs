using Foodzilla.Kernel.Domain;
using Microsoft.EntityFrameworkCore;

namespace Foodzilla.Domain.Aggregates.Customer;

public class Product : Entity<int>
{

    private readonly List<Order> _orders = new();

    public string Sku { get; private set; } = null!;

    public string Title { get; private set; } = null!;

    public decimal Price { get; private set; }

    public string Description { get; private set; } = null!;


    [BackingField(nameof(_orders))]
    public virtual IReadOnlyCollection<Order> Orders => _orders;

    public Product()
    {

    }

    private Product(string sku, string title, decimal price, string description)
    {
        Sku = sku;
        Title = title;
        Price = price;
        Description = description;
    }

    public static Product Create(string sku, string title, decimal price, string description)
    {
        return new Product(sku, title, price, description);
    }
}