using System.Data.Entity;

namespace PersonnelTrackingSystem.DAL
{
    public partial class PersonnelTrackingDbContext : DbContext
    {
        public PersonnelTrackingDbContext()
            : base("name=PersonnelTrackingDbContext")
        {
        }

        public virtual DbSet<Personel> Personel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
