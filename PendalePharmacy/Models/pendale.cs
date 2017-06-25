namespace PendalePharmacy.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class pendale : DbContext
    {
        public pendale()
            : base("name=pendale")
        {
        }

        public virtual DbSet<Drugs> Drugs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
