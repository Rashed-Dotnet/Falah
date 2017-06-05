namespace DAL.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Canteen> Canteens { get; set; }
        public virtual DbSet<College> Colleges { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_College> tbl_College { get; set; }
        public virtual DbSet<tbl_Dept> tbl_Dept { get; set; }
        public virtual DbSet<tbl_Student> tbl_Student { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Canteen>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Canteen>()
                .Property(e => e.MenuType)
                .IsUnicode(false);

            modelBuilder.Entity<Canteen>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<College>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<College>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<College>()
                .Property(e => e.Affiliation)
                .IsUnicode(false);

            modelBuilder.Entity<College>()
                .Property(e => e.Contactno)
                .IsUnicode(false);

            modelBuilder.Entity<College>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Hods)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Library>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Library>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Phoneno)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.AcademicYear)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_College>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_College>()
                .Property(e => e.CollegeType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_College>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Dept>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Dept>()
                .HasMany(e => e.tbl_College)
                .WithOptional(e => e.tbl_Dept)
                .HasForeignKey(e => e.DeptId);

            modelBuilder.Entity<tbl_Student>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Student>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Student>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Student>()
                .HasMany(e => e.tbl_College)
                .WithOptional(e => e.tbl_Student)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .IsFixedLength();
        }
    }
}
