namespace eInspektor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.report")]
    public partial class report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int control_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string content { get; set; }

        public sbyte control_justified { get; set; }

        public virtual control control { get; set; }
    }
}
