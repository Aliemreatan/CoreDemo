using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
	public class Context: DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-VLIOH37;database=CoreBlogApiDb;integrated security=true;Trust Server Certificate=true;");
			base.OnConfiguring(optionsBuilder);
		}

        public DbSet<Employee> Employees { get; set; }
    }
}
