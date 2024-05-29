using Hotels.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*modelBuilder.Entity<Branch>().ToTable("Branches", "branch");*/
            string NorthCoast_id = Guid.NewGuid().ToString();
            string Alexandria_id = Guid.NewGuid().ToString();
            string Hurgada_id = Guid.NewGuid().ToString();
            modelBuilder.Entity<Branch>().HasData(
            new Branch
            {
                Id = NorthCoast_id,
                Name = "NorthCoast",
                Address = "NorthCoast Address"
            },
            new Branch
            {
                Id = Alexandria_id,
                Name = "Alexandria",
                Address = "Alexandria Address"
            },
            new Branch
            {
                Id = Hurgada_id,
                Name = "Hurgada",
                Address = "Hurgada Address"
            }
            );

            modelBuilder.Entity<Branch>()
                .Property(x => x.Address).IsRequired(false);
        }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Room> Rooms { get; set; }

    }
}
