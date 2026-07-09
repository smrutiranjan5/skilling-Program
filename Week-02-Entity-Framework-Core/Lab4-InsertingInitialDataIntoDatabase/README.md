# Lab 4: Inserting Initial Data into the Database

## Objective

Learn how to insert records into SQL Server using Entity Framework Core with `AddAsync()`, `AddRangeAsync()`, and `SaveChangesAsync()`.

---

## Scenario

The retail store manager wants to add initial product categories and products into the RetailStore database.

---

## Tools & Technologies

- C#
- .NET 10 Console Application
- Entity Framework Core 10
- SQL Server
- SQL Server Management Studio (SSMS)
- EF Core CLI

---

## Project Structure

```
RetailStoreInsertData
│
├── Data
│   └── AppDbContext.cs
│
├── Models
│   ├── Category.cs
│   └── Product.cs
│
├── Migrations
│
├── Program.cs
│
└── RetailStoreInsertData.csproj
```

---

## Steps Performed

### Create DbContext

Configured SQL Server connection using Entity Framework Core.

---

### Insert Categories

```csharp
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

await context.Categories.AddRangeAsync(electronics, groceries);
```

---

### Insert Products

```csharp
var product1 = new Product
{
    Name = "Laptop",
    Price = 75000,
    Category = electronics
};

var product2 = new Product
{
    Name = "Rice Bag",
    Price = 1200,
    Category = groceries
};

await context.Products.AddRangeAsync(product1, product2);
```

---

### Save Data

```csharp
await context.SaveChangesAsync();
```

---

## Run Application

```bash
dotnet run
```

---

## SQL Verification

```sql
USE RetailStoreDB;
GO

SELECT * FROM Categories;

SELECT * FROM Products;
```

---

## Output

Console Output

```
Initial data inserted successfully!
```

Categories Table

| Id | Name |
|----|------|
|1|Electronics|
|2|Groceries|

Products Table

| Id | Name | Price | CategoryId |
|----|--------|---------:|-----------:|
|1|Laptop|75000.00|1|
|2|Rice Bag|1200.00|2|

---

## Learning Outcome

- Learned how to insert data using Entity Framework Core.
- Used `AddRangeAsync()` for multiple records.
- Used `SaveChangesAsync()` to persist data.
- Verified inserted data in SQL Server.

---

## Result

The initial categories and products were successfully inserted into the RetailStoreDB database using Entity Framework Core and verified in SQL Server.