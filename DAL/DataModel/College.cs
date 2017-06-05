namespace DAL.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("College")]
    public partial class College
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(50)]
        public string Affiliation { get; set; }

        [StringLength(50)]
        public string Contactno { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? StudentId { get; set; }

        public int? DepartmentId { get; set; }

        public int? CanteenId { get; set; }

        public int? LibraryId { get; set; }

        public virtual Canteen Canteen { get; set; }

        public virtual Department Department { get; set; }

        public virtual Library Library { get; set; }

        public virtual Student Student { get; set; }
    }
}
