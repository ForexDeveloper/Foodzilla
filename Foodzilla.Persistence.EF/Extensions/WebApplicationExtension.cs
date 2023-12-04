using Foodzilla.Domain.Enums;
using Microsoft.AspNetCore.Builder;
using Foodzilla.Persistence.EF.Data;
using Foodzilla.Domain.Aggregates.Customer;
using Microsoft.Extensions.DependencyInjection;

namespace Foodzilla.Persistence.EF.Extensions;

public static class WebApplicationExtension
{
    public static WebApplication Seed(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        try
        {
            context.Database.EnsureCreated();

            var customer = context.Customers.FirstOrDefault();

            if (customer == null)
            {
                var now = DateTimeOffset.Now;

                var customer1 = Customer.Create("MohammadReza", "JavidPoor", "4120583732", "String", null, CustomerRank.Gold, null, true, null, 10, null, 40, null, 321312.12321M, null, 400, null, Guid.NewGuid(), null, now, null);
                var customer2 = Customer.Create("Mehran", "Hashemi", "3120583632", "String", null, CustomerRank.Silver, CustomerRank.Diamond, true, null, 10, null, 40, null, 321312.12321M, null, 400, null, Guid.NewGuid(), null, now, null);
                var customer3 = Customer.Create("Mehran", "Hashemi", "3120583632", "String", null, CustomerRank.Diamond, CustomerRank.Silver, true, false, 10, null, 40, null, 321312.12321M, null, 400, null, Guid.NewGuid(), null, now, null);
                var customer4 = Customer.Create("Mehdi", "Ebrahimi", "0120583632", "String", null, CustomerRank.Gold, CustomerRank.Normal, true, false, 10, 20, 40, null, 321312.12321M, null, 400, null, Guid.NewGuid(), null, now, null);
                var customer5 = Customer.Create("Ghazaleh", "Eshghi", "9120583632", "String", null, CustomerRank.Gold, CustomerRank.Normal, true, false, 10, 20, 40, 50, 321312.12321M, null, 400, null, Guid.NewGuid(), null, now, null);
                var customer6 = Customer.Create("Amir", "Heydari", "3120583632", "String", null, CustomerRank.Gold, CustomerRank.Normal, true, false, 10, 20, 40, 50, 321312.12321M, null, 400, 56, Guid.NewGuid(), null, now, null);
                var customer7 = Customer.Create("Amin", "Salami", "3120583632", "String", null, CustomerRank.Gold, CustomerRank.Normal, true, false, 10, 20, 40, 50, 321312.12321M, null, 400, 56, Guid.NewGuid(), null, now, now.AddDays(120));

                var customer8 = Customer.Create("MohammadReza", "JavidPoor", "4120583732", "String", "StringNullable", CustomerRank.Gold, null, true, null, 10, null, 40, null, 321312.12321M, null, 400, null, Guid.NewGuid(), null, now, null);
                var customer9 = Customer.Create("Mehran", "Hashemi", "3120583632", "String", "StringNullable", CustomerRank.Silver, CustomerRank.Diamond, true, null, 10, null, 40, null, 321312.12321M, null, 400, null, Guid.NewGuid(), null, now, null);
                var customer10 = Customer.Create("Mehran", "Hashemi", "3120583632", "String", "StringNullable", CustomerRank.Diamond, CustomerRank.Silver, true, false, 10, null, 40, null, 321312.12321M, null, 400, null, Guid.NewGuid(), null, now, null);
                var customer11 = Customer.Create("Mehdi", "Ebrahimi", "0120583632", "String", "StringNullable", CustomerRank.Gold, CustomerRank.Normal, true, false, 10, 20, 40, null, 321312.12321M, null, 400, null, Guid.NewGuid(), null, now, null);
                var customer12 = Customer.Create("Queen", "Eshghi", "9120583632", "String", "StringNullable", CustomerRank.Gold, CustomerRank.Normal, true, false, 10, 20, 40, 50, 321312.12321M, null, 400, null, Guid.NewGuid(), null, now, null);
                var customer13 = Customer.Create("Amir", "Heydari", "3120583632", "String", "StringNullable", CustomerRank.Gold, CustomerRank.Normal, true, false, 10, 20, 40, 50, 321312.12321M, null, 400, 56, Guid.NewGuid(), null, now, null);
                var customer14 = Customer.Create("Amin", "Salami", "3120583632", "String", "StringNullable", CustomerRank.Gold, CustomerRank.Normal, true, false, 10, 20, 40, 50, 321312.12321M, null, 400, 56, Guid.NewGuid(), null, now, now.AddDays(120));

                context.Customers.AddRange(customer1, customer2, customer3, customer3, customer4, customer5, customer6, customer7, customer8, customer9, customer10,
                    customer10, customer11, customer12, customer13, customer14);

                context.SaveChanges();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return app;
    }
}