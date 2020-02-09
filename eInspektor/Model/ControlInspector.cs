namespace eInspektor.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ControlInspector : DbContext
    {
        public ControlInspector()
            : base("name=ControlInspector")
        {
        }

        public virtual DbSet<control_has_inspector> control_has_inspector { get; set; }
        public virtual DbSet<joint_control> joint_control { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
