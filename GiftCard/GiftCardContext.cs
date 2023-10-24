using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftCard
{
    internal class GiftCardContext : DbContext
    {
        public DbSet<GiftCard> GiftCards { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=tcp:applicationdev.database.windows.net,1433;Initial Catalog=giftcarddb;Persist Security Info=False;User ID=applicationdev;Password=GiftCard1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>().HasKey(user => user.username);
        }

    }
}
