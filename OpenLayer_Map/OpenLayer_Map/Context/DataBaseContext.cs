using OpenLayer_Map.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OpenLayer_Map.Context
{
    public class DataBaseContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Köprğlerimiz
            //modelBuilder.Entity<Borrow>().HasRequired<User>(a => a.User).WithMany(t => t.Borrows).HasForeignKey(u => u.UserId);
        }
        public DataBaseContext() : base("name = MappAppContextDb")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, LibraryApplication.Migrations.Configuration>("MappAppContextDb"));
        }
        public virtual DbSet<Kapi> Kapis { get; set; }
        public virtual DbSet<Mahalle> MahalleList { get; set; }
        
        public object Mahalle { get; set; }
        public object Kapi { get; set; }
    }
}