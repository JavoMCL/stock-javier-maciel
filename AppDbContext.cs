   using Microsoft.EntityFrameworkCore;
   using Backend.Models.Entidades;

   namespace Backend.Models
   {
       public class AppDbContext : DbContext
       {
           public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

           public DbSet<Cliente> Clientes { get; set; }
           public DbSet<Proveedor> Proveedores { get; set; }
           public DbSet<Producto> Productos { get; set; }
           public DbSet<Compras> Compras { get; set; }
           // Agrega aquí los DbSet que necesites
       }
   }
   