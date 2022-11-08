using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.DOMAIN.Models
{
    public class CoursesSubject
    {
        [Key]
        public long CSID { get; set; } 
        public DateTime DateCreated { get; set; }

        public long CourseID { get; set; }
        public Courses Course { get; set; }

        public long SubjectID { get; set; }
        public Subjects  Subjects { get; set; }
    }
}
