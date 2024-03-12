using Microsoft.EntityFrameworkCore;
using PousadaAPI.Models;

namespace PousadaAPI.Data
{
    public class PousadaContext : DbContext
    {
        public PousadaContext(DbContextOptions<PousadaContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}