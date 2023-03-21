using System.Data.Entity;

namespace IronHelmOrderSystem.Entities
{
    public partial class DatabaseEntities : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<ScheduleItem> ScheduleItems { get; set; }

        public DatabaseEntities() : base("name=conString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
