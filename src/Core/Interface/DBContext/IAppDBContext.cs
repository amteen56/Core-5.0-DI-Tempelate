using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interface.DBContext
{
    public class IAppDbContext : DbContext
    {
        public IAppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("APPDEV");
            //modelBuilder.Entity<USERSETUP>().HasKey(o => o.USER_ID);

            //modelBuilder.Entity<TAG_USERAPPSCR>()
            //    .HasOne(o => o.USERSETUP)
            //    .WithMany(o => o.lnk_AppScreenTags)
            //    .HasForeignKey(o => o.USER_ID);

            //modelBuilder.Entity<Meal_Row>().HasNoKey();




        }
        //public DbSet<Surrender> Surrender { get; set; }
    }

}