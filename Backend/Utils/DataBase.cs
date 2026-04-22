using Backend.Models;
using Backend.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Backend.Utils;

public static class DataBase
{
    public static readonly Dictionary<int, Cliente> TABLA_CLIENTE = new();
    public static readonly Dictionary<int, Producto> TABLA_PRODUCTOS = new();
    public static readonly Dictionary<int, Proveedor> TABLA_PROVEEDOR = new();
    public static readonly Dictionary<int, Genero> TABLA_GENEROS = new();
    public static readonly Dictionary<int, TipoTelefono> TABLA_TIPOS_TELEFONO = new();

    private static AppDbContext CreateContext()
    {
        var connectionString = DatabaseConfiguration.GetConnectionString();
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            .Options;

        return new AppDbContext(options);
    }

    private static void RefreshCaches(AppDbContext context)
    {
        TABLA_GENEROS.Clear();
        foreach (var genero in context.Generos.AsNoTracking().ToList())
        {
            TABLA_GENEROS[genero.id] = genero;
        }

        TABLA_TIPOS_TELEFONO.Clear();
        foreach (var tipoTelefono in context.TiposTelefono.AsNoTracking().ToList())
        {
            TABLA_TIPOS_TELEFONO[tipoTelefono.id] = tipoTelefono;
        }

        TABLA_PROVEEDOR.Clear();
        foreach (var proveedor in context.Proveedores.AsNoTracking().ToList())
        {
            TABLA_PROVEEDOR[proveedor.idProveedor] = proveedor;
        }

        TABLA_PRODUCTOS.Clear();
        foreach (var producto in context.Productos.AsNoTracking().Include(x => x.proveedor).ToList())
        {
            TABLA_PRODUCTOS[producto.idProducto] = producto;
        }

        TABLA_CLIENTE.Clear();
        foreach (var cliente in context.Clientes.AsNoTracking().Include(x => x.genero).Include(x => x.tipoTelefono).ToList())
        {
            TABLA_CLIENTE[cliente.idCliente] = cliente;
        }
    }

    public static Array obtenerTipoTelefono()
    {
        using var context = CreateContext();
        RefreshCaches(context);
        return TABLA_TIPOS_TELEFONO.Values.ToArray();
    }

    public static Array obtenerProveedor()
    {
        using var context = CreateContext();
        RefreshCaches(context);
        return TABLA_PROVEEDOR.Values.ToArray();
    }

    public static void guardarProveedor(Proveedor proveedor)
    {
        using var context = CreateContext();

        if (proveedor.idProveedor == 0)
        {
            proveedor.fechaRegistro = proveedor.fechaRegistro == default ? DateTime.Now : proveedor.fechaRegistro;
            context.Proveedores.Add(proveedor);
        }
        else
        {
            var entity = context.Proveedores.FirstOrDefault(x => x.idProveedor == proveedor.idProveedor);
            if (entity is null)
            {
                context.Proveedores.Add(proveedor);
            }
            else
            {
                entity.nombre = proveedor.nombre;
                entity.email = proveedor.email;
                entity.telefono = proveedor.telefono;
                entity.direcccion = proveedor.direcccion;
                entity.fechaRegistro = proveedor.fechaRegistro == default ? entity.fechaRegistro : proveedor.fechaRegistro;
            }
        }

        context.SaveChanges();
        RefreshCaches(context);
    }

    public static void guardarCliente(Cliente cliente)
    {
        using var context = CreateContext();

        var tipoTelefono = cliente.tipoTelefono is null
            ? null
            : context.TiposTelefono.FirstOrDefault(x => x.id == cliente.tipoTelefono.id);

        var genero = cliente.genero is null
            ? null
            : context.Generos.FirstOrDefault(x => x.id == cliente.genero.id);

        if (cliente.idCliente == 0)
        {
            cliente.fechaRegistroCliente = cliente.fechaRegistroCliente == default ? DateTime.Now : cliente.fechaRegistroCliente;
            cliente.tipoTelefono = tipoTelefono;
            cliente.genero = genero;
            context.Clientes.Add(cliente);
        }
        else
        {
            var entity = context.Clientes
                .Include(x => x.genero)
                .Include(x => x.tipoTelefono)
                .FirstOrDefault(x => x.idCliente == cliente.idCliente);

            if (entity is null)
            {
                cliente.tipoTelefono = tipoTelefono;
                cliente.genero = genero;
                context.Clientes.Add(cliente);
            }
            else
            {
                entity.nombreCliente = cliente.nombreCliente;
                entity.apellidoCliente = cliente.apellidoCliente;
                entity.numDocumento = cliente.numDocumento;
                entity.emailCliente = cliente.emailCliente;
                entity.telefonoCliente = cliente.telefonoCliente;
                entity.direccionCliente = cliente.direccionCliente;
                entity.tipoTelefono = tipoTelefono;
                entity.genero = genero;
                entity.fechaRegistroCliente = cliente.fechaRegistroCliente == default ? entity.fechaRegistroCliente : cliente.fechaRegistroCliente;
            }
        }

        context.SaveChanges();
        RefreshCaches(context);
    }

    public static Array obtenerCliente()
    {
        using var context = CreateContext();
        RefreshCaches(context);
        return TABLA_CLIENTE.Values.ToArray();
    }

    public static void agregarProducto(Producto producto)
    {
        using var context = CreateContext();

        var proveedor = producto.proveedor is null
            ? null
            : context.Proveedores.FirstOrDefault(x => x.idProveedor == producto.proveedor.idProveedor);

        if (producto.idProducto == 0)
        {
            producto.proveedor = proveedor;
            context.Productos.Add(producto);
        }
        else
        {
            var entity = context.Productos.Include(x => x.proveedor).FirstOrDefault(x => x.idProducto == producto.idProducto);
            if (entity is null)
            {
                producto.proveedor = proveedor;
                context.Productos.Add(producto);
            }
            else
            {
                entity.nombreProducto = producto.nombreProducto;
                entity.descripcionProducto = producto.descripcionProducto;
                entity.precio = producto.precio;
                entity.stock = producto.stock;
                entity.proveedor = proveedor;
            }
        }

        context.SaveChanges();
        RefreshCaches(context);
    }

    public static Array obtenerProducto()
    {
        using var context = CreateContext();
        RefreshCaches(context);
        return TABLA_PRODUCTOS.Values.ToArray();
    }

    public static void eliminarProducto(int productID)
    {
        using var context = CreateContext();
        var producto = context.Productos.FirstOrDefault(x => x.idProducto == productID);
        if (producto is null)
        {
            return;
        }

        context.Productos.Remove(producto);
        context.SaveChanges();
        RefreshCaches(context);
    }

    public static void agregarCompra(Compras compra)
    {
        using var context = CreateContext();

        var proveedor = compra.proveedor is null
            ? null
            : context.Proveedores.FirstOrDefault(x => x.idProveedor == compra.proveedor.idProveedor);

        if (compra.idCompra == 0)
        {
            compra.fechaCompra = compra.fechaCompra == default ? DateTime.Now : compra.fechaCompra;
            compra.proveedor = proveedor;
            context.Compras.Add(compra);
        }
        else
        {
            var entity = context.Compras.Include(x => x.proveedor).FirstOrDefault(x => x.idCompra == compra.idCompra);
            if (entity is null)
            {
                compra.proveedor = proveedor;
                context.Compras.Add(compra);
            }
            else
            {
                entity.proveedor = proveedor;
                entity.fechaCompra = compra.fechaCompra;
                entity.total = compra.total;
            }
        }

        context.SaveChanges();
    }

    public static Array ObtenerCompra()
    {
        using var context = CreateContext();
        return context.Compras.AsNoTracking().Include(x => x.proveedor).ToArray();
    }

    public static void guardarVenta(Ventas venta)
    {
        using var context = CreateContext();

        var cliente = venta.cliente is null
            ? null
            : context.Clientes.FirstOrDefault(x => x.idCliente == venta.cliente.idCliente);

        if (venta.idVenta == 0)
        {
            venta.fechaVenta = venta.fechaVenta == default ? DateTime.Now : venta.fechaVenta;
            venta.cliente = cliente;
            context.Ventas.Add(venta);
        }
        else
        {
            var entity = context.Ventas.Include(x => x.cliente).FirstOrDefault(x => x.idVenta == venta.idVenta);
            if (entity is null)
            {
                venta.cliente = cliente;
                context.Ventas.Add(venta);
            }
            else
            {
                entity.cliente = cliente;
                entity.fechaVenta = venta.fechaVenta;
                entity.total = venta.total;
                entity.formaPago = venta.formaPago;
            }
        }

        context.SaveChanges();
    }

    public static Array ObtenerVentas()
    {
        using var context = CreateContext();
        return context.Ventas.AsNoTracking().Include(x => x.cliente).ToArray();
    }

    public static void guardarDetalleVenta(DetalleVenta detalle)
    {
        using var context = CreateContext();

        var venta = detalle.venta is null
            ? null
            : context.Ventas.FirstOrDefault(x => x.idVenta == detalle.venta.idVenta);

        var producto = detalle.producto is null
            ? null
            : context.Productos.FirstOrDefault(x => x.idProducto == detalle.producto.idProducto);

        detalle.venta = venta;
        detalle.producto = producto;

        if (detalle.idDetalleVenta == 0)
        {
            context.DetallesVenta.Add(detalle);
        }
        else
        {
            context.DetallesVenta.Update(detalle);
        }

        context.SaveChanges();
    }

    public static void guardarDetalleCompra(DetalleCompra detalle)
    {
        using var context = CreateContext();

        var compra = detalle.compra is null
            ? null
            : context.Compras.FirstOrDefault(x => x.idCompra == detalle.compra.idCompra);

        var producto = detalle.producto is null
            ? null
            : context.Productos.FirstOrDefault(x => x.idProducto == detalle.producto.idProducto);

        detalle.compra = compra;
        detalle.producto = producto;

        if (detalle.detalleCompra == 0)
        {
            context.DetallesCompra.Add(detalle);
        }
        else
        {
            context.DetallesCompra.Update(detalle);
        }

        context.SaveChanges();
    }

    public static void guardarGenero(Genero genero)
    {
        using var context = CreateContext();
        var entity = context.Generos.FirstOrDefault(x => x.id == genero.id);
        if (entity is null)
        {
            context.Generos.Add(genero);
        }
        else
        {
            entity.descripcion = genero.descripcion;
        }

        context.SaveChanges();
        RefreshCaches(context);
    }

    public static Array obtenerGeneros()
    {
        using var context = CreateContext();
        RefreshCaches(context);
        return TABLA_GENEROS.Values.ToArray();
    }

    public static void guardarTipoTelefono(TipoTelefono tipoTelefono)
    {
        using var context = CreateContext();
        var entity = context.TiposTelefono.FirstOrDefault(x => x.id == tipoTelefono.id);
        if (entity is null)
        {
            context.TiposTelefono.Add(tipoTelefono);
        }
        else
        {
            entity.descripcion = tipoTelefono.descripcion;
        }

        context.SaveChanges();
        RefreshCaches(context);
    }
}

