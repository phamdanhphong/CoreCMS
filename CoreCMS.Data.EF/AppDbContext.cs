using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreCMS.Data.EF.Configuarations;
using CoreCMS.Data.EF.Extensions;
using CoreCMS.Data.Entities;
using CoreCMS.Data.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CoreCMS.Data.EF
{
    public class AppDbContext : IdentityDbContext
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
        public DbSet<Role> Roles { set; get; }
        public DbSet<Setting> Settings { set; get; }
        public DbSet<SubItem> SubItems { set; get; }
        public DbSet<User> Users { set; get; }

       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.AddConfiguration(new SettingConfiguration());
            base.OnModelCreating(builder);
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
}
