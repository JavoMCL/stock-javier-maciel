using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context
{
    // Clase de compatibilidad para codigo legado que aun referencia StockContext.
    public class StockContext : AppDbContext
    {
        public StockContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}