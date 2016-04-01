using DatabaseProjectIAmDb.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace DatabaseProjectIAmDb.DataContexts
{
    public class IdentityDb : IdentityDbContext<ApplicationUser, CustomRole, int,
                                CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public IdentityDb()
            : base("DefaultConnection")
        {
        }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Item_In_Transaction> ItemsInTransactions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Person> People { get; set; }


    }
}
