namespace eInspektor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.company")]
    public partial class company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public company()
        {
            controls = new HashSet<control>();
            complaints = new HashSet<complaint>();
            lab_sample = new HashSet<lab_sample>();
        }

        public int id { get; set; }

        public int jib { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        [StringLength(1000)]
        public string location { get; set; }

        [Required]
        [StringLength(255)]
        public string owner { get; set; }

        [StringLength(255)]
        public string bookkeeper { get; set; }

        [Column(TypeName = "date")]
        public DateTime? last_control { get; set; }

        [StringLength(255)]
        public string last_control_type { get; set; }

        public sbyte isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<control> controls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<complaint> complaints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lab_sample> lab_sample { get; set; }
    }
}
