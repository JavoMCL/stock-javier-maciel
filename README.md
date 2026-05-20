# Stock Management System - Javier Maciel

> **Note:** This project is entirely in Spanish because it was developed as a university project. Variable names, UI texts, forms, and database structures are written in Spanish.

Stock management system developed in C# using WinForms and Entity Framework Core, designed to manage suppliers, products, customers, purchases, and sales.

## Prerequisites

- **.NET 8.0** or higher
- **MySQL 8.0** or higher
- **Visual Studio 2022** or Rider (JetBrains)
- **dotnet-cli** (for EF Core migrations)

---

## Installation

### 1. Clone the repository

```bash
git clone https://github.com/your-username/stock-javier-maciel.git
cd stock-javier-maciel
```

### 2. Configure the database

#### Option A: Run the SQL script

```bash
mysql -u root -p < init_database.sql
```

Enter your password when prompted.

#### Option B: Create the structure manually

```sql
CREATE DATABASE IF NOT EXISTS stock_db;
USE stock_db;

-- Execute the contents of init_database.sql
```

### 3. Configure the connection string

Edit `ui/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=stock_db;user=root;password=YOUR_PASSWORD;"
  }
}
```

Replace `YOUR_PASSWORD` with your MySQL password.

### 4. Build the solution

```bash
dotnet build
```

### 5. Run the application

```bash
dotnet run --project ui/ui.csproj
```

---

## Project Structure

```text
stock-javier-maciel/
├── Backend/                          # Business logic and data layer
│   ├── Models/
│   │   ├── Entidades/               # Model classes (Cliente, Producto, etc.)
│   │   └── AppDbContext.cs          # EF Core context
│   ├── Context/
│   │   ├── AppDbContext.cs
│   │   ├── AppDbContextFactory.cs   # Factory for migrations
│   │   └── StockContext.cs
│   ├── Utils/
│   │   ├── DataBase.cs              # Static data access layer
│   │   └── DatabaseConfiguration.cs # Connection string resolution
│   └── Backend.csproj
├── ui/                               # User interface (WinForms)
│   ├── Clientes/                    # Customer management
│   │   ├── frmGestionCliente.cs
│   │   └── frmListaClientes.cs
│   ├── Productos/                   # Product management
│   │   ├── frmAgregarProducto.cs
│   │   └── frmListaDeProductos.cs
│   ├── Proveedores/                 # Supplier management
│   │   ├── frmGestionProveedor.cs
│   │   └── frmListarProveedor.cs
│   ├── Compra/                      # Purchase management
│   │   ├── frmNuevaCompra.cs
│   │   └── frmListaCompras.cs
│   ├── Ventas/                      # Sales management
│   │   ├── frmVentas.cs
│   │   └── frmListaVentas.cs
│   ├── appsettings.json             # Connection configuration
│   └── ui.csproj
├── init_database.sql                 # Database initialization script
└── stock-javier-maciel.sln          # Visual Studio solution
```

---

## Features

### Supplier Management

- Create, edit, and delete suppliers
- Store name, email, phone number, and address
- Required field validation

### Product Management

- Create, edit, and delete products
- Assign suppliers
- Manage price and stock
- Display product list without redundant supplier data

### Customer Management

- Create, edit, and delete customers
- Store gender and phone type
- Complete data validation

### Purchase Management

- Register new purchases with suppliers
- Add multiple products per purchase
- Payment types: Cash or Credit
- View purchase details (products, quantities, prices)
- Automatic stock updates
- Save and Cancel buttons

### Sales Management

- Register sales with customers
- Add multiple products per sale
- Available stock validation
- Payment methods: Cash or Credit
- View sale details
- Save and Cancel buttons
- Automatic stock updates

### UI/UX

- Visual icons for edit, delete, and detail actions
- Defensive validations (invalid rows, null entities)
- Confirmation messages before deletion
- Error handling for referential integrity constraints

---

## Configuration

### Environment variable (alternative to appsettings.json)

```bash
# Windows PowerShell
$env:STOCK_CONNECTION_STRING = "server=localhost;database=stock_db;user=root;password=MyPassword;"
```

The application prioritizes the environment variable if it is defined.

---

## Database

### Main tables

- `clientes` - Customer data
- `proveedores` - Supplier data
- `productos` - Product catalog
- `compras` - Purchase headers
- `detalles_compra` - Purchase lines
- `ventas` - Sales headers
- `detalles_venta` - Sales lines
- `genero` - Gender catalog
- `tipo_telefono` - Phone type catalog

### Relationships

- `producto` → `proveedor` (restriction: cannot delete supplier with assigned products)
- `compra` → `proveedor` (restriction: cannot delete supplier with purchases)
- `venta` → `cliente` (restriction: cannot delete customer with sales)
- `detalle_venta` → `venta` (cascade delete enabled)
- `detalle_venta` → `producto` (restriction)

---

## Validations

The application implements validations during save operations:

- **Required fields:** Name, email, phone number, address (depending on entity)
- **Prices and quantities:** Must be greater than zero
- **Relationships:** Supplier/Customer required for purchases and sales
- **Stock:** Cannot sell more than available stock
- **Referential integrity:** Entities with related records cannot be deleted

---

## Technologies

- **Language:** C# (.NET 8.0)
- **UI:** Windows Forms
- **ORM:** Entity Framework Core 8.0
- **Database:** MySQL with Pomelo.EntityFrameworkCore.MySql
- **Dependency Injection:** Microsoft.Extensions.DependencyInjection

---

## Development Notes

### Add migrations (if you modify the model)

```bash
dotnet tool install --global dotnet-ef
dotnet ef migrations add MigrationName --project Backend --startup-project ui
dotnet ef database update --project Backend --startup-project ui
```

### Build

```bash
dotnet build --configuration Release
```

### Executable

```bash
# Debug
dotnet run --project ui/ui.csproj

# Release
dotnet run --project ui/ui.csproj --configuration Release
```

---

## Troubleshooting

### Error: "DefaultConnection not found"

- Verify that `appsettings.json` exists inside `ui/`
- Check the connection string syntax
- Ensure MySQL is running

### Error: "Not enough stock"

- Check the product inventory
- Register a purchase to increase stock

### Unable to delete a supplier/customer

- The entity has related records (products/sales)
- Delete or reassign dependent records first

---

## License

Personal stock management project.

---

## Author

Javier Maciel

---

**Last updated:** April 2026
