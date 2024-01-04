using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PayrollManagement.Business.ModuleCity.Models;
using PayrollManagement.Business.ModuleCompany.Models;
using PayrollManagement.Business.ModuleCostCenter.Models;
using PayrollManagement.Business.ModuleRegion.Models;
using PayrollManagement.Business.ModuleRole.Models;
using PayrollManagement.Business.ModuleUser.Models;
using PayrollManagement.Business.ModuleUserActivity.Models;
using PayrollManagement.Business.ModuleUserInfo.Models;
using PayrollManagement.Business.ModuleWorker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Infraestructure.Data
{
    public class AppDbContext : IdentityDbContext<User,Role,long>
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
        }




    }
}
