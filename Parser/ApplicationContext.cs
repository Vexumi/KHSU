using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Parser.Model;

namespace Parser
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Experiment> Experiments { get; set; } = null!;
        public DbSet<User> Users { get; set; }

        private string connectionString;

        public ApplicationContext(string connectionString)
        {
            this.connectionString = connectionString;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
