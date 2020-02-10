namespace eInspektor.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseModel : DbContext
    {
        public DatabaseModel()
            : base("name=DatabaseModel2")
        {
        }

        public virtual DbSet<absence> absences { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<complaint> complaints { get; set; }
        public virtual DbSet<control> controls { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<inspector> inspectors { get; set; }
        public virtual DbSet<lab_sample> lab_sample { get; set; }
        public virtual DbSet<vehicle> vehicles { get; set; }
        public virtual DbSet<vehicle_responsibility> vehicle_responsibility { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<absence>()
                .Property(e => e.absence_purpose)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.owner)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.bookkeeper)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .Property(e => e.last_control_type)
                .IsUnicode(false);

            modelBuilder.Entity<company>()
                .HasMany(e => e.controls)
                .WithRequired(e => e.company)
                .HasForeignKey(e => e.company_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<company>()
                .HasMany(e => e.complaints)
                .WithRequired(e => e.company)
                .HasForeignKey(e => e.company_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<company>()
                .HasMany(e => e.lab_sample)
                .WithRequired(e => e.company)
                .HasForeignKey(e => e.company_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<complaint>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<complaint>()
                .Property(e => e.issuer)
                .IsUnicode(false);

            modelBuilder.Entity<control>()
                .Property(e => e.report_content)
                .IsUnicode(false);

            modelBuilder.Entity<control>()
                .HasMany(e => e.complaints)
                .WithOptional(e => e.control)
                .HasForeignKey(e => e.control_id);

            modelBuilder.Entity<control>()
                .HasMany(e => e.vehicle_responsibility)
                .WithOptional(e => e.control)
                .HasForeignKey(e => e.control_id);

            modelBuilder.Entity<control>()
                .HasMany(e => e.inspectors)
                .WithMany(e => e.controls)
                .Map(m => m.ToTable("control_has_inspector", "is-proj"));

            modelBuilder.Entity<department>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<inspector>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<inspector>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<inspector>()
                .Property(e => e.department)
                .IsUnicode(false);

            modelBuilder.Entity<inspector>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<inspector>()
                .Property(e => e.salt)
                .IsUnicode(false);

            modelBuilder.Entity<inspector>()
                .Property(e => e.password_hash)
                .IsUnicode(false);

            modelBuilder.Entity<inspector>()
                .HasMany(e => e.absences)
                .WithRequired(e => e.inspector)
                .HasForeignKey(e => e.inspector_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<inspector>()
                .HasMany(e => e.lab_sample)
                .WithRequired(e => e.inspector)
                .HasForeignKey(e => e.inspector_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<inspector>()
                .HasMany(e => e.vehicle_responsibility)
                .WithRequired(e => e.inspector)
                .HasForeignKey(e => e.inspector_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lab_sample>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle>()
                .Property(e => e.registration_num)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle>()
                .Property(e => e.tag)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle>()
                .HasMany(e => e.vehicle_responsibility)
                .WithRequired(e => e.vehicle)
                .HasForeignKey(e => e.vehicle_id)
                .WillCascadeOnDelete(false);
        }
    }
}
