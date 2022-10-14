using Microsoft.EntityFrameworkCore;
using  TigerStaplers.Models;

namespace TigerStaplers.Data
{
    public class TigerStaplersContext : DbContext
    {
        public TigerStaplersContext(DbContextOptions<TigerStaplersContext> options)
            : base(options)
        {
        }

        public DbSet<Stapler> Stapler { get; set; }
    }
}