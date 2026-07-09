# Lab 3: Using EF Core CLI to Create and Apply Migrations

## Objective
Learn how to use Entity Framework Core CLI to create and apply database migrations in SQL Server.

---

## Scenario

The retail store database needs to be created from the Product and Category models. EF Core Migrations are used to generate the database schema automatically.

---

## Tools & Technologies

- C#
- .NET 10 Console Application
- Entity Framework Core 10
- SQL Server
- SQL Server Management Studio (SSMS)
- EF Core CLI (dotnet-ef)

---

## Project Structure

```
RetailStoreMigrations
│
├── Data
│   └── AppDbContext.cs
│
├── Models
│   ├── Category.cs
│   └── Product.cs
│
├── Migrations
│   ├── InitialCreate.cs
│   ├── InitialCreate.Designer.cs
│   └── AppDbContextModelSnapshot.cs
│
├── Program.cs
├── appsettings.json
└── RetailStoreMigrations.csproj
```

---

## EF Core CLI Commands Used

### Install EF Core CLI

```bash
dotnet tool install --global dotnet-ef
```

### Verify Installation

```bash
dotnet ef --version
```

### Create Initial Migration

```bash
dotnet ef migrations add InitialCreate
```

### Apply Migration

```bash
dotnet ef database update
```

---

## Database Created

Database Name

```
RetailStoreDB
```

Tables Created

- Categories
- Products
- __EFMigrationsHistory

---

## SQL Verification

```sql
USE RetailStoreDB;
GO

SELECT * FROM INFORMATION_SCHEMA.TABLES;
```

---

## Output

After applying the migration:

- Migrations folder generated successfully.
- SQL Server database created.
- Categories table created.
- Products table created.
- __EFMigrationsHistory table created.
- Verified successfully in SQL Server Management Studio.

---

## Learning Outcome

- Learned how EF Core CLI works.
- Generated migrations from C# models.
- Applied migrations to SQL Server.
- Verified database schema in SSMS.
- Understood how EF Core automatically creates database tables from model classes.

---

## Result

The RetailStoreDB database was successfully created using Entity Framework Core Migrations. The Products and Categories tables were generated automatically and verified in SQL Server Management Studio.