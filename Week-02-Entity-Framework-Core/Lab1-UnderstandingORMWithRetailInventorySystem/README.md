# Lab 1: Understanding ORM with a Retail Inventory System

## Objective

The objective of this lab is to understand Object Relational Mapping (ORM) and learn how Entity Framework Core (EF Core) helps connect C# objects with SQL Server database tables. This lab also introduces EF Core 8.0 and demonstrates how to create a .NET Console Application with the required EF Core packages.

---

## Scenario

A retail store wants to build an inventory management system to manage products, categories, and stock information using SQL Server. Entity Framework Core is used as the ORM framework to simplify database operations.

---

## What is ORM?

Object Relational Mapping (ORM) is a technique that maps C# classes to relational database tables.

Instead of writing SQL queries manually, developers can work with C# objects while EF Core automatically performs database operations.

### Benefits of ORM

- Increases developer productivity
- Reduces SQL coding
- Improves code maintainability
- Provides abstraction from SQL
- Simplifies database interactions

---

## EF Core vs Entity Framework

| Entity Framework Core | Entity Framework 6 |
|------------------------|--------------------|
| Cross-platform | Windows only |
| Lightweight | Heavier framework |
| High performance | Comparatively slower |
| Supports LINQ, Async Queries, Compiled Models | Limited modern features |
| Actively developed | Maintenance mode |

---

## EF Core 8.0 Features

- JSON Column Mapping
- Improved Performance
- Compiled Models
- Better Bulk Operations
- Interceptors
- Cross-platform Support

---

## Software Used

- Visual Studio 2026
- .NET 10 Console Application
- SQL Server
- SQL Server Management Studio (SSMS)
- Entity Framework Core 10.0.9

---

## NuGet Packages Installed

- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design

---

## Project Structure

```
RetailInventory
│
├── Data
│   └── RetailDbContext.cs
│
├── Models
│   ├── Category.cs
│   └── Product.cs
│
├── appsettings.json
├── Program.cs
└── RetailInventory.csproj
```

---

## Output

The application was successfully built and executed.

Console Output:

```
Retail Inventory System using EF Core 8.0
```

---

## Conclusion

This lab provided a basic understanding of Object Relational Mapping (ORM) and Entity Framework Core. A .NET Console Application was created successfully, the required EF Core packages were installed, and the project was prepared for database integration in upcoming labs.