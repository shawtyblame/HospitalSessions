using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Gender> Genders => Set<Gender>();
        public DbSet<HealingEvent> HealingEvents=> Set<HealingEvent>();
        public DbSet<HealingEventType> HealingEventTypes => Set<HealingEventType>(); 
        public DbSet<Hospitalization> Hospitalizations => Set<Hospitalization>(); 
        public DbSet<HospitalizationCondition> HospitalizationConditions => Set<HospitalizationCondition>(); 
        public DbSet<HospitalizationStatus> HospitalizationStatus => Set<HospitalizationStatus>(); 
        public DbSet<MedicalCard> MedicalCards=> Set<MedicalCard>();
        public DbSet<RequestVisit> RequestVisits => Set<RequestVisit>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<UserAddictional> UserAddictionals => Set<UserAddictional>();
        public DbSet<UserCredentional> UserCredentionals => Set<UserCredentional>();
        public DbSet<UserMainInfo> UserMainInfos => Set<UserMainInfo>();
        public DbSet<Visit> Visit => Set<Visit>();         

        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Doctor" }

                );
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 2, Name = "Reseption" }

                );
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 3, Name = "Patient" }

                );

            modelBuilder.Entity<Department>().HasData
                (
                new Department { Id = 1, Number = 101 }
                );

            modelBuilder.Entity<Department>().HasData
                (
                new Department { Id = 2, Number = 102 }
                );
            modelBuilder.Entity<Department>().HasData
                (
                new Department { Id = 3, Number = 103 }
                );

            modelBuilder.Entity<HospitalizationCondition>().HasData
                (
                new HospitalizationCondition { Id = 1, Name = "Платно"}
                );
            modelBuilder.Entity<HospitalizationCondition>().HasData
                (
                new HospitalizationCondition { Id = 2, Name = "Бюджет" }
                );

            modelBuilder.Entity<Gender>().HasData
                (
                new Gender { Id=1,Name="Male"}
                );
            modelBuilder.Entity<Gender>().HasData
                (
                new Gender { Id = 2, Name = "Female" }
                );




        }
    }
}
