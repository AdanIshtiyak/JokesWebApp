using Microsoft.EntityFrameworkCore;

namespace SaveVers.Models
{
    public class DB : DbContext
    {
        public DbSet<Analyzes> _analyzes {get; set;}
        public DbSet<Norms> _norms { get; set; }
    }
}
