using AR.Domain;
using Microsoft.EntityFrameworkCore;

namespace AR.Data
{
    public class ContextoPricinpal : DbContext
    {
        public ContextoPricinpal(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Cliente> Cliente { get; set; }
        
    }
}