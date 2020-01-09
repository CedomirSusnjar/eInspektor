namespace eInspektor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.inspector")]
    public partial class inspector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inspector()
        {
            absences = new HashSet<absence>();
            lab_sample = new HashSet<lab_sample>();
            vehicle_responsibility = new HashSet<vehicle_responsibility>();
            controls = new HashSet<control>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string first_name { get; set; }

        [Required]
        [StringLength(255)]
        public string last_name { get; set; }

        [Required]
        [StringLength(255)]
        public string department { get; set; }

        public int unavailable { get; set; }

        public int shift { get; set; }

        public sbyte is_coordinator { get; set; }

        [Required]
        [StringLength(45)]
        public string username { get; set; }

        [Required]
        [StringLength(45)]
        public string salt { get; set; }

        [Required]
        [StringLength(255)]
        public string password_hash { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<absence> absences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lab_sample> lab_sample { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vehicle_responsibility> vehicle_responsibility { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<control> controls { get; set; }
    }
}
