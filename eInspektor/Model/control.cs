namespace eInspektor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.control")]
    public partial class control
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public control()
        {
            complaints = new HashSet<complaint>();
            vehicle_responsibility = new HashSet<vehicle_responsibility>();
            inspectors = new HashSet<inspector>();
        }

        public int id { get; set; }

        public int company_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? finish_date { get; set; }

        public sbyte is_finished { get; set; }

        public sbyte is_regular { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string report_content { get; set; }

        public sbyte? control_justified { get; set; }

        public sbyte isActive { get; set; }

        public virtual company company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<complaint> complaints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vehicle_responsibility> vehicle_responsibility { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inspector> inspectors { get; set; }
    }
}
