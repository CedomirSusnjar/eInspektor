namespace eInspektor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.vehicle")]
    public partial class vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehicle()
        {
            vehicle_responsibility = new HashSet<vehicle_responsibility>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string registration_num { get; set; }

        public int max_capacity { get; set; }

        [StringLength(45)]
        public string tag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vehicle_responsibility> vehicle_responsibility { get; set; }
    }
}
