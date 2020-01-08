namespace eInspektor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.lab_sample")]
    public partial class lab_sample
    {
        public int id { get; set; }

        public int company_id { get; set; }

        public int inspector_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string description { get; set; }

        public virtual company company { get; set; }

        public virtual inspector inspector { get; set; }
    }
}
