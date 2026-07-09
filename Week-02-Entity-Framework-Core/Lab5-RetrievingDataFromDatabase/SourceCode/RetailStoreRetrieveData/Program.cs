using Microsoft.EntityFrameworkCore;
using RetailStoreRetrieveData.Data;

using var context = new AppDbContext();

var products = await context.Products.ToListAsync();

Console.WriteLine("All Products:");
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

var product = await context.Products.FindAsync(1);

Console.WriteLine($"\nFound: {product?.Name}");

var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"Expensive: {expensive?.Name}");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();