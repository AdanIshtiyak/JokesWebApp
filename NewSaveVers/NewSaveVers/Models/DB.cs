using Microsoft.EntityFrameworkCore;

namespace NewSaveVers.Models
{
    public class DB : DbContext
    {
        public DbSet<Analyzes> Analyzes { get; set; }
        public DbSet<Norms> Norms { get; set; }
    }
}
