using Microsoft.EntityFrameworkCore;
using PayrollManagement.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Infraestructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<City> City { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CostCenter> CostCenter { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserActivity> UserActivity { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Worker> Worker { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Al crear modelo crear relaciones

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CostCenter>()
                .HasOne(c => c.User)
                .WithOne(u => u.CostCenter)
                .HasForeignKey<User>(u => u.CostCenterId)
                .IsRequired(false);
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserInfo)
                .WithOne(us => us.User)
                .HasForeignKey<UserInfo>(u => u.UserId)
                .IsRequired(false);
            modelBuilder.Entity<Worker>()
                .HasOne(w => w.UserInfo)
                .WithOne(us => us.Worker)
                .HasForeignKey<UserInfo>(u => u.WorkerId)
                .IsRequired(false); 
               
        }




    }
}
