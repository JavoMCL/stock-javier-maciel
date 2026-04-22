using Backend.Models;
using Backend.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Proveedor> Proveedores => Set<Proveedor>();
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<Compras> Compras => Set<Compras>();
        public DbSet<DetalleCompra> DetallesCompra => Set<DetalleCompra>();
        public DbSet<Ventas> Ventas => Set<Ventas>();
        public DbSet<DetalleVenta> DetallesVenta => Set<DetalleVenta>();
        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<TipoTelefono> TiposTelefono => Set<TipoTelefono>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasKey(x => x.idCliente);
            modelBuilder.Entity<Proveedor>().HasKey(x => x.idProveedor);
            modelBuilder.Entity<Producto>().HasKey(x => x.idProducto);
            modelBuilder.Entity<Compras>().HasKey(x => x.idCompra);
            modelBuilder.Entity<DetalleCompra>().HasKey(x => x.detalleCompra);
            modelBuilder.Entity<Ventas>().HasKey(x => x.idVenta);
            modelBuilder.Entity<DetalleVenta>().HasKey(x => x.idDetalleVenta);
            modelBuilder.Entity<Genero>().HasKey(x => x.id);
            modelBuilder.Entity<TipoTelefono>().HasKey(x => x.id);

            // Mapear nombres de tabla
            modelBuilder.Entity<Genero>().ToTable("genero");
            modelBuilder.Entity<TipoTelefono>().ToTable("tipo_telefono");
            modelBuilder.Entity<Cliente>().ToTable("clientes");
            modelBuilder.Entity<Proveedor>().ToTable("proveedores");
            modelBuilder.Entity<Producto>().ToTable("productos");
            modelBuilder.Entity<Compras>().ToTable("compras");
            modelBuilder.Entity<DetalleCompra>().ToTable("detalles_compra");
            modelBuilder.Entity<Ventas>().ToTable("ventas");
            modelBuilder.Entity<DetalleVenta>().ToTable("detalles_venta");

            // Relaciones
            modelBuilder.Entity<Producto>()
                .HasOne(x => x.proveedor)
                .WithMany()
                .HasForeignKey(x => x.idProveedor)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Compras>()
                .HasOne(x => x.proveedor)
                .WithMany()
                .HasForeignKey(x => x.idProveedor)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ventas>()
                .HasOne(x => x.cliente)
                .WithMany()
                .HasForeignKey(x => x.idCliente)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(x => x.venta)
                .WithMany()
                .HasForeignKey(x => x.idVenta)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(x => x.producto)
                .WithMany()
                .HasForeignKey(x => x.idProducto)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleCompra>()
                .HasOne(x => x.producto)
                .WithMany()
                .HasForeignKey(x => x.idProducto)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleCompra>()
                .HasOne(x => x.compra)
                .WithMany()
                .HasForeignKey(x => x.idCompra)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cliente>()
                .HasOne(x => x.genero)
                .WithMany()
                .HasForeignKey(x => x.idGenero)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Cliente>()
                .HasOne(x => x.tipoTelefono)
                .WithMany()
                .HasForeignKey(x => x.idTipoTelefono)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

