using Microsoft.EntityFrameworkCore;
using Proyecto24Bm.Models;

namespace Proyecto24Bm.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
    }
}
