namespace eInspektor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.complaint")]
    public partial class complaint
    {
        public int id { get; set; }

        public int company_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string text { get; set; }

        [StringLength(255)]
        public string issuer { get; set; }

        public sbyte? is_justified { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public int? control_id { get; set; }

        public sbyte? is_resolved { get; set; }

        public virtual company company { get; set; }

        public virtual control control { get; set; }
    }
}
