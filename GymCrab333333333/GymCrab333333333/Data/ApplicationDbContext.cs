using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymCrab333333333.Models;

namespace GymCrab333333333.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GymCrab333333333.Models.Joke>? Joke { get; set; }

        public DbSet<GymCrab333333333.Models.Workout>? Workout { get; set; }
        public DbSet<GymCrab333333333.Models.Exercise> Exercise { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ensure the relationship between Exercise and Workout is properly configured
            modelBuilder.Entity<Exercise>()
                .HasOne(e => e.Workout)
                .WithMany(w => w.Exercises)
                .HasForeignKey(e => e.WorkoutId)
                .OnDelete(DeleteBehavior.Restrict); // Change to Restrict if you want to prevent deleting a Workout with associated Exercises

        }
    }



}
