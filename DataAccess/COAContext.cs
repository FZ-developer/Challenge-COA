using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class COAContext : DbContext
    {
        public COAContext(DbContextOptions<COAContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
