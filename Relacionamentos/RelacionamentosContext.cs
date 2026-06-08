using Microsoft.EntityFrameworkCore;
using Relacionamentos.Models;

namespace Relacionamentos
{
    public class RelacionamentosContext : DbContext
    {
        public RelacionamentosContext(DbContextOptions 
            options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
