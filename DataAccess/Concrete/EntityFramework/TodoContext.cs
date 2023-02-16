using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.FakeDataGenerators.Bogus;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Task = Entities.Concrete.Task;

namespace DataAccess.Concrete.EntityFramework
{
    public class TodoContext:DbContext
    {
        public DbSet<Color> Colors { get; set; }
        public DbSet<Task> Tasks{ get; set; }
        public DbSet<TaskGroup> TaskGroups { get; set; }
        public DbSet<TaskPriority> TaskPriorities { get; set; }
        public DbSet<TaskState> TaskStates { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TodoAppDb; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>(a =>
            {

                a.ToTable("Colors").HasKey(k => k.Id);
                a.Property(p => p.ColorCode).HasColumnName("ColorCode");
                a.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                a.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");

            });
            modelBuilder.Entity<Task>(a =>
            {

                a.ToTable("Tasks").HasKey(k => k.Id);
                a.Property(p => p.CategoryId).HasColumnName("CategoryId");
                a.Property(p => p.TaskGroupId).HasColumnName("TaskGroupId");
                a.Property(p => p.TaskPriorityId).HasColumnName("TaskPriorityId");
                a.Property(p => p.UserId).HasColumnName("UserId");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.Description).HasColumnName("Description");
                a.Property(p => p.StartDate).HasColumnName("StartDate");
                a.Property(p => p.EndDate).HasColumnName("EndDate");
                a.Property(p => p.PlannedStartDate).HasColumnName("PlannedStartDate");
                a.Property(p => p.PlannedEndDate).HasColumnName("PlannedEndDate");
                a.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                a.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");


            });
            modelBuilder.Entity<TaskGroup>(a =>
            {

                a.ToTable("TaskGroups").HasKey(k => k.Id);

                a.Property(p => p.UserId).HasColumnName("UserId");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.Description).HasColumnName("Description");
                a.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                a.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");

            });
            modelBuilder.Entity<TaskPriority>(a =>
            {

                a.ToTable("TaskPriorities").HasKey(k => k.Id);
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.Level).HasColumnName("Level");
                a.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                a.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");

            }); modelBuilder.Entity<TaskState>(a =>
            {

                a.ToTable("TaskStates").HasKey(k => k.Id);

                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.Level).HasColumnName("Level");
                a.Property(p => p.ColorId).HasColumnName("ColorId");
                a.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                a.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<User>(a =>
            {

                a.ToTable("Users").HasKey(k => k.Id);
                a.Property(p => p.FirstName).HasColumnName("FirstName");
                a.Property(p => p.LastName).HasColumnName("LastName");
                a.Property(p => p.Email).HasColumnName("Email");
                a.Property(p => p.Phone).HasColumnName("Phone");
                a.Property(p => p.Status).HasColumnName("Status");
                a.Property(p => p.PasswordHash).HasColumnName("PasswordHash");
                a.Property(p => p.PasswordSalt).HasColumnName("PasswordSalt");
                a.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                a.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<User>().HasData(DataGenerator<User>.GenerateData());

        }


    }
}
