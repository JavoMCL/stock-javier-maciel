# Sistema de Stock - Javier Maciel

Sistema de gestión de inventario desarrollado en C# con WinForms y Entity Framework Core, diseñado para administrar proveedores, productos, clientes, compras y ventas.

##  Requisitos Previos

- **.NET 8.0** o superior
- **MySQL 8.0** o superior
- **Visual Studio 2022** o Rider (JetBrains)
- **dotnet-cli** (para migraciones EF Core)

##  Instalación

### 1. Clonar el repositorio
```bash
git clone https://github.com/tu-usuario/stock-javier-maciel.git
cd stock-javier-maciel
```

### 2. Configurar la base de datos

#### Opción A: Ejecutar el script SQL
```bash
mysql -u root -p < init_database.sql
```

Ingresa tu contraseña cuando se solicite.

#### Opción B: Crear estructura manualmente
```sql
CREATE DATABASE IF NOT EXISTS stock_db;
USE stock_db;

-- Ejecuta el contenido del archivo init_database.sql
```

### 3. Configurar la cadena de conexión

Edita `ui/appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=stock_db;user=root;password=TU_PASSWORD;"
  }
}
```

Reemplaza `TU_PASSWORD` con tu contraseña de MySQL.

### 4. Compilar la solución
```bash
dotnet build
```

### 5. Ejecutar la aplicación
```bash
dotnet run --project ui/ui.csproj
```

##  Estructura del Proyecto

```
stock-javier-maciel/
├── Backend/                          # Capa de lógica y datos
│   ├── Models/
│   │   ├── Entidades/               # Clases de modelo (Cliente, Producto, etc.)
│   │   └── AppDbContext.cs          # Contexto EF Core
│   ├── Context/
│   │   ├── AppDbContext.cs
│   │   ├── AppDbContextFactory.cs   # Factory para migraciones
│   │   └── StockContext.cs
│   ├── Utils/
│   │   ├── DataBase.cs              # Capa estática de acceso a datos
│   │   └── DatabaseConfiguration.cs # Resolución de cadena de conexión
│   └── Backend.csproj
├── ui/                               # Interfaz de usuario (WinForms)
│   ├── Clientes/                    # Gestión de clientes
│   │   ├── frmGestionCliente.cs
│   │   └── frmListaClientes.cs
│   ├── Productos/                   # Gestión de productos
│   │   ├── frmAgregarProducto.cs
│   │   └── frmListaDeProductos.cs
│   ├── Proveedores/                 # Gestión de proveedores
│   │   ├── frmGestionProveedor.cs
│   │   └── frmListarProveedor.cs
│   ├── Compra/                      # Gestión de compras
│   │   ├── frmNuevaCompra.cs
│   │   └── frmListaCompras.cs
│   ├── Ventas/                      # Gestión de ventas
│   │   ├── frmVentas.cs
│   │   └── frmListaVentas.cs
│   ├── appsettings.json             # Configuración de conexión
│   └── ui.csproj
├── init_database.sql                 # Script de inicialización BD
└── stock-javier-maciel.sln          # Solución Visual Studio
```

##  Características

### Gestión de Proveedores
- Crear, editar y eliminar proveedores
- Registrar nombre, email, teléfono y dirección
- Validación de campos obligatorios

### Gestión de Productos
- Crear, editar y eliminar productos
- Asignar proveedor
- Controlar precio y stock
- Visualizar listado sin proveedor redundante

### Gestión de Clientes
- Crear, editar y eliminar clientes
- Registrar género y tipo de teléfono
- Validación de datos completos

### Gestión de Compras
- Registrar nuevas compras con proveedor
- Agregar múltiples productos por compra
- Tipo de pago: Contado o Crédito
- Visualizar detalles de compra (productos, cantidades, precios)
- Actualizar stock automáticamente
- Botones Guardar y Cancelar

### Gestión de Ventas
- Registrar ventas con cliente
- Agregar múltiples productos a la venta
- Control de stock disponible
- Forma de pago: Contado o Crédito
- Visualizar detalles de venta
- Botones Guardar y Cancelar
- Actualizar stock automáticamente

### UI/UX
- Iconos visuales para editar, eliminar y ver detalles
- Validaciones defensivas (filas inválidas, entidades nulas)
- Mensajes de confirmación antes de eliminar
- Manejo de errores (restricciones de integridad referencial)

##  Configuración

### Variable de entorno (alternativa a appsettings.json)
```bash
# Windows PowerShell
$env:STOCK_CONNECTION_STRING = "server=localhost;database=stock_db;user=root;password=MiPassword;"
```

La aplicación prioriza la variable de entorno si está definida.

##  Base de Datos

### Tablas principales
- `clientes` - Datos de clientes
- `proveedores` - Datos de proveedores
- `productos` - Catálogo de productos
- `compras` - Cabecera de compras
- `detalles_compra` - Líneas de compra
- `ventas` - Cabecera de ventas
- `detalles_venta` - Líneas de ventas
- `genero` - Catálogo de géneros
- `tipo_telefono` - Catálogo de tipos de teléfono

### Relaciones
- `producto` → `proveedor` (restricción: no eliminable si tiene productos)
- `compra` → `proveedor` (restricción: no eliminable si tiene compras)
- `venta` → `cliente` (restricción: no eliminable si tiene ventas)
- `detalle_venta` → `venta` (cascada: se borran detalles si se borra venta)
- `detalle_venta` → `producto` (restricción)

##  Validaciones

La aplicación implementa validaciones en tiempo de guardado:

- **Campos obligatorios**: Nombre, email, teléfono, dirección (según entidad)
- **Precios y cantidades**: Deben ser mayores a cero
- **Relaciones**: Proveedor/Cliente requerido en compra/venta
- **Stock**: No puede venderse más de lo disponible
- **Integridad referencial**: No se pueden eliminar entidades con registros relacionados

## 🛠 Tecnologías

- **Lenguaje**: C# (.NET 8.0)
- **UI**: Windows Forms
- **ORM**: Entity Framework Core 8.0
- **BD**: MySQL con Pomelo.EntityFrameworkCore.MySql
- **Inyección de dependencias**: Microsoft.Extensions.DependencyInjection

##  Notas de Desarrollo

### Agregar migraciones (si modificas el modelo)
```bash
dotnet tool install --global dotnet-ef
dotnet ef migrations add NombreMigracion --project Backend --startup-project ui
dotnet ef database update --project Backend --startup-project ui
```

### Compilación
```bash
dotnet build --configuration Release
```

### Ejecutable
```bash
# Debug
dotnet run --project ui/ui.csproj

# Release
dotnet run --project ui/ui.csproj --configuration Release
```

##  Solución de Problemas

### Error: "No se encontró DefaultConnection"
- Verifica que `appsettings.json` exista en `ui/`
- Revisa la sintaxis de la cadena de conexión
- Asegúrate de que la BD MySQL está en ejecución

### Error: "No hay suficiente stock"
- Verifica el inventario del producto
- Realiza una compra para incrementar stock

### No se puede eliminar un proveedor/cliente
- Tiene registros relacionados (productos/ventas)
- Primero elimina o reasigna los registros dependientes

##  Licencia

Proyecto personal de gestión de stock.

##  Autor

Javier Maciel

---

**Última actualización**: Abril 2026

