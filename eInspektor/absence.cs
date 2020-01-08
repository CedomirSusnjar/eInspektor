namespace eInspektor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.absence")]
    public partial class absence
    {
        public int id { get; set; }

        public int inspector_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_from { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_to { get; set; }

        public int? duration_days { get; set; }

        [StringLength(255)]
        public string absence_purpose { get; set; }

        public virtual inspector inspector { get; set; }
    }
}
