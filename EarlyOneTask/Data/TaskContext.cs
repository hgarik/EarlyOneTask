using EarlyOneTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyOneTask.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options)
        : base(options)
        { }

        public DbSet<Account> Account { get; set; }
        public DbSet<StudentScore> StudentScore { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<AccountSubject> AccountSubject { get; set; }
        public DbSet<AccountSession> AccountSession { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasData(
                new Account { Id = 1, RoleId = 1 },
                new Account { Id = 2, RoleId = 2 },
                new Account { Id = 3, RoleId = 3 }
                );

            modelBuilder.Entity<Role>()
                .HasData(
                    new Role { Id = 1, Name = "Principal" },
                    new Role { Id = 2, Name = "Teacher" },
                    new Role { Id = 3, Name = "Student" }
                );

            modelBuilder.Entity<AccountSession>()
                .HasData(
                    new AccountSession { Id = 1, AccountId = 1, Token = Guid.NewGuid().ToString() },
                    new AccountSession { Id = 2, AccountId = 2, Token = Guid.NewGuid().ToString() },
                    new AccountSession { Id = 3, AccountId = 3, Token = Guid.NewGuid().ToString() }
                );

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasOne(a => a.Role).WithMany(r => r.Accounts).HasForeignKey(f => f.RoleId);
            });
            modelBuilder.Entity<StudentScore>()
                .HasIndex(s => s.SubjectId);
        }
    }
}
