using static EUserManager.Data.EntityUser;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace EUserManager.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent Api
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            //Data seeding
            modelBuilder.Entity<User>().HasData(GenerateUsers());

            modelBuilder.Entity<User>().Property(u => u.CreateDate).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<User>().Property(u => u.UpdateDate).HasDefaultValueSql("GETDATE()");
        }
        private User[] GenerateUsers()
        {
            var users = new User[50];
            for (int i = 0; i < 50; i++)
            {
                users[i] = new User
                {
                    Id = i + 1,
                    Username = $"User{i + 1}",
                    Password = "123456",
                    Email = $"user{i + 1}@example.com",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                };
            }
            return users;
        }
    }
}
