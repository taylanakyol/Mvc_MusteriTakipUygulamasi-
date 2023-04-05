using Microsoft.EntityFrameworkCore;

namespace Mvc_MusteriTakipUygulaması.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=DbMusteriTakip; integrated security=true; Encrypt=False;");

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<WorkList> WorkLists { get; set; }
        
    }
}
