using Foodzilla.Kernel.Domain;

namespace Foodzilla.Domain.Aggregates.Customer;

public sealed class Order : Entity<long>
{
    public long UserId { get; private set; }

    public int ProductId { get; private set; }

    public Product Product { get; private set; } = null!;

    public int CustomerId { get; private set; }

    public Customer Customer { get; private set; } = null!;

    public DateTimeOffset OrderDate { get; private set; }

    public Order()
    {

    }

    private Order(long userId, int productId, int customerId, DateTimeOffset orderDate)
    {
        UserId = userId;
        ProductId = productId;
        CustomerId = customerId;
        OrderDate = orderDate;
    }

    public static Order Create(long userId, int productId, int customerId, DateTimeOffset orderDate)
    {
        return new Order(userId, productId, customerId, orderDate);
    }
}