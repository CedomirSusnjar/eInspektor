namespace eInspektor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.joint_control")]
    public partial class joint_control
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int control_id { get; set; }

        public int department_id { get; set; }
    }
}
