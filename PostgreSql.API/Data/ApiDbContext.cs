using Microsoft.EntityFrameworkCore;
using PostgreSql.API.Models;

namespace PostgreSql.API.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<DriverMedia> DriverMedias { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Driver>(driver =>
            {
                // 1 - Many
                driver.HasOne(t => t.Team) // every driver has one team 
                    .WithMany(d => d.Drivers) // every team has many drivers
                    .HasForeignKey(d => d.TeamId) // every driver has a foreign key -> TeamId
                    .OnDelete(DeleteBehavior.Restrict) // Don't allow to delete anything when there exists a relation. 
                    .HasConstraintName("FK_Driver_Team");

                // 1 - 1
                driver.HasOne(dm => dm.DriverMedia)
                      .WithOne(d => d.Driver)
                      .HasForeignKey<DriverMedia>(dm => dm.DriverId); // Here EF will add a constraint name by default and default delete behaviour
                                                                      // .OnDelete(DeleteBehavior.Cascade) will also be added 

                // Rename Table Drivers to F1Drivers
                driver.ToTable("F1Drivers");
            });
        }
    }
}
