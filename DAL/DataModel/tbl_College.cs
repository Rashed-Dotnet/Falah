namespace DAL.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_College
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string CollegeType { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public int? StudentId { get; set; }

        public int? DeptId { get; set; }

        public virtual tbl_Dept tbl_Dept { get; set; }

        public virtual tbl_Student tbl_Student { get; set; }
    }
}
