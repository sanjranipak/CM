using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.DOMAIN.Models
{
    public class TeachersCourses
    {
        [Key]
        public long TCID { get; set; }
  
       
        public DateTime DateCreated { get; set; }

        public long TeacherID { get; set; }
        public Teachers Teacher { get; set; }

        public long CourseID { get; set; }
        public Courses Course { get; set; }

    }
}
