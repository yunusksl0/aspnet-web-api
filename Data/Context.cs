using Microsoft.EntityFrameworkCore;
using userAPI.Models;

namespace userAPI.Data
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("server=your-server;database=new-database-name;Integrated Security=True;Trust Server Certificate=True;");
        }


        public DbSet<User> users { get; set; }

    }
}
