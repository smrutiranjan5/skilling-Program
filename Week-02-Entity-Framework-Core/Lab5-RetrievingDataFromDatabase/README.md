# Lab 5: Retrieving Data from the Database

## Objective

Learn how to retrieve data from SQL Server using Entity Framework Core asynchronous methods.

---

## Scenario

The retail store wants to display product details on the dashboard. Data needs to be retrieved from the existing database using different Entity Framework Core query methods.

---

## Tools & Technologies

- C#
- .NET 10 Console Application
- Entity Framework Core 10
- SQL Server
- SQL Server Management Studio (SSMS)
- Visual Studio 2022

---

## Project Structure

```
RetailStoreRetrieveData
│
├── Data
│   └── AppDbContext.cs
│
├── Models
│   ├── Category.cs
│   └── Product.cs
│
├── Program.cs
└── appsettings.json
```

---

## Database Used

Database Name

```
RetailStoreDB
```

Existing Tables

- Categories
- Products
- __EFMigrationsHistory

---

## Retrieving Data

### Retrieve All Products

```csharp
var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}
```

---

### Find Product by ID

```csharp
var product = await context.Products.FindAsync(1);

Console.WriteLine($"Found: {product?.Name}");
```

---

### Retrieve First Expensive Product

```csharp
var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"Expensive: {expensive?.Name}");
```

---

## Run the Application

```bash
dotnet run
```

---

## SQL Verification

```sql
USE RetailStoreDB;
GO

SELECT * FROM Products;

SELECT * FROM Categories;
```

---

## Output

Console Output

```
All Products:

Laptop - ₹75000
Rice Bag - ₹1200

Found: Laptop

Expensive: Laptop
```

Database Output

Products Table

| Id | Name | Price | CategoryId |
|----|------|-------|------------|
| 1 | Laptop | 75000 | 1 |
| 2 | Rice Bag | 1200 | 2 |

Categories Table

| Id | Name |
|----|-------------|
| 1 | Electronics |
| 2 | Groceries |

---

## Learning Outcome

- Learned how to retrieve all records using ToListAsync().
- Learned how to retrieve a single record using FindAsync().
- Learned how to filter records using FirstOrDefaultAsync().
- Connected Entity Framework Core with SQL Server.
- Verified retrieved data using SQL Server Management Studio.

---

## Result

The product data was successfully retrieved from the SQL Server database using Entity Framework Core asynchronous query methods. All retrieval operations were verified successfully in SQL Server Management Studio.