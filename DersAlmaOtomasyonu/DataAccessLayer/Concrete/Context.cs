using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8M7D7GE\\SQLEXPRESS;Database=DersAlmaOtomasyonu;integrated security=true;");
            //optionsBuilder.UseSqlServer("Server=MK\\SQLEXPRESS;Database=DersAlmaOtomasyonu;integrated security=true;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<CourseSelection> CourseSelections { get; set; }
    }
}
