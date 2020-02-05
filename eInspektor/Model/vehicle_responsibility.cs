namespace eInspektor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("is-proj.vehicle_responsibility")]
    public partial class vehicle_responsibility
    {
        public int id { get; set; }

        public int vehicle_id { get; set; }

        public int inspector_id { get; set; }

        public int? control_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public virtual control control { get; set; }

        public virtual inspector inspector { get; set; }

        public virtual vehicle vehicle { get; set; }
    }
}
