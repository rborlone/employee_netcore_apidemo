using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
            
        }

        public DbSet <Empleado> Empleados { get; set; }
    }
}