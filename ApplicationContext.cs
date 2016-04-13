using GridViewProject.Models;
using System.Data.Entity;

namespace GridViewProject.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("GridViewContext")
        {

        }
        public DbSet<Currency> Currencies { get; set; }
    }
}