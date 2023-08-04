using Hidden.Moose.Domain.Catalog;
using Hidden.Moose.Domain.Orders;
using Microsoft.EntityFrameworkCore;


namespace Hidden.Moose.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) 
            : base(options)
        { }
        
        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
