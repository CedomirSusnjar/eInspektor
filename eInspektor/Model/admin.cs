namespace eInspektor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.admin")]
    public partial class admin
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string username { get; set; }

        [Required]
        [StringLength(45)]
        public string salt { get; set; }

        [Required]
        [StringLength(255)]
        public string password_hash { get; set; }

        public sbyte isActive { get; set; }
    }
}
