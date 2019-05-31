using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CoreCMS.Data.EF.Configuarations;
using CoreCMS.Data.EF.Extensions;
using CoreCMS.Data.Entities;
using CoreCMS.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CoreCMS.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Group> Groups { set; get; }
        public DbSet<GroupItem> GroupItems { set; get; }
        public DbSet<Item> Items { set; get; }
        public DbSet<LanguageItem> LanguageItems { set; get; }
        public DbSet<LanguageKey> LanguageKeys { set; get; }
        public DbSet<LanguageNational> LanguageNationals { set; get; }
        public DbSet<Log> Logs { set; get; }
        public DbSet<Members> Members { set; get; }
        public DbSet<AppRole> AppRoles { set; get; }
        public DbSet<Setting> Settings { set; get; }
        public DbSet<SubItem> SubItems { set; get; }
        public DbSet<AppUser> AppUsers { set; get; }

       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Identity Config

            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims")
                .HasKey(x => x.Id);

            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
                .HasKey(x => new { x.RoleId, x.UserId });

            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens")
                .HasKey(x => new { x.UserId });

            #endregion Identity Config
            builder.AddConfiguration(new SettingConfiguration());
            //base.OnModelCreating(builder);
        }


        public override int SaveChanges()
        {

            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach ( EntityEntry item in modified)
            {
                if (item.Entity is IDateTracking changeOrAddedItem)
                {
                    if (item.State == EntityState.Added)
                    {
                        changeOrAddedItem.DateCreated=DateTime.Now;
                        
                    }
                    changeOrAddedItem.DateModified=DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new AppDbContext(builder.Options);
        }
    }
}
