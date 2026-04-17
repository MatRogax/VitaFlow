using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using projeto_carlos.Models;
using projeto_carlos.Models.Entities;

namespace VitaFlow.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Journal> Journals { get; set; } = default!;
        public DbSet<Psychologist> Psychologists { get; set; } = default!;
        public DbSet<Appointment> Appointments { get; set; } = default!;

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Relationships
            
            // User -> Journals
            modelBuilder.Entity<Journal>()
                .HasOne(j => j.User)
                .WithMany(u => u.Journals)
                .HasForeignKey(j => j.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User (Patient) -> Appointments
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(u => u.Appointments)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Cascade);

            // Psychologist -> User (Optional)
            modelBuilder.Entity<Psychologist>()
                .HasOne(p => p.User)
                .WithOne()
                .HasForeignKey<Psychologist>(p => p.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            // Appointment -> Psychologist
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Psychologist)
                .WithMany()
                .HasForeignKey(a => a.PsychologistId)
                .OnDelete(DeleteBehavior.Restrict);

            // Psychologist Tags Conversion (List<string> -> JSON string for SQLite)
            modelBuilder.Entity<Psychologist>()
                .Property(p => p.Tags)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null) ?? new List<string>()
                );
        }
    }
}