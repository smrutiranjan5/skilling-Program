# Lab 2: Setting Up the Database Context for a Retail Store

## Objective
Configure Entity Framework Core DbContext and connect a .NET Console Application to SQL Server.

---

## Technologies Used

- C#
- .NET 10 Console Application
- Entity Framework Core 10
- SQL Server
- Visual Studio 2026

---

## NuGet Packages Installed

- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design

---

## Project Structure

```
RetailStoreDbContext
│
├── Data
│   └── AppDbContext.cs
│
├── Models
│   ├── Category.cs
│   └── Product.cs
│
├── Program.cs
├── appsettings.json
└── RetailStoreDbContext.csproj
```

---

## Models

### Category

Contains category information.

Properties:

- Id
- Name
- Products

---

### Product

Contains product information.

Properties:

- Id
- Name
- Price
- CategoryId
- Category

---

## Database Context

Created **AppDbContext** by inheriting from `DbContext`.

Configured:

- Products DbSet
- Categories DbSet
- SQL Server Connection

---

## Connection String

```json
{
  "ConnectionStrings": {
    "RetailDbConnection": "Server=localhost;Database=RetailStoreDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

---

##  Program Output

```
Retail Store Database Context configured successfully using Entity Framework Core!

Press any key to exit...
```

---

## Output

The execution screenshot is available in the **Screenshot** folder.

---

## Outcome

- Created Entity classes.
- Configured AppDbContext.
- Connected EF Core with SQL Server.
- Successfully built and executed the Console Application.
- Verified the project configuration.

---

## Concepts Learned

- Object Relational Mapping (ORM)
- Entity Framework Core
- DbContext
- DbSet
- SQL Server Connection
- Entity Relationships