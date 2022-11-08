using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.DOMAIN.Models;


namespace CM.Repository
{
    public class CMDbContext : DbContext
    {
        public CMDbContext():base("name=MyEntities")
        {

        }

       
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<TeachersCourses> TearchersCourses { get; set; }
    }
}
