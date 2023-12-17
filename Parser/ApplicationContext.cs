using Microsoft.EntityFrameworkCore;
using Parser.Model;

namespace Parser
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Experiment> Experiments { get; set; } = null!;
        public DbSet<UserModel> Users { get; set; }

        private string connectionString;

        public ApplicationContext(string connectionString)
        {
            this.connectionString = connectionString;
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel
                {
                    Id = Guid.NewGuid(),
                    Username = "admin",
                    Password = "admin",
                    Role = UserRole.Administrator
                }
            );
        }
    }
}
