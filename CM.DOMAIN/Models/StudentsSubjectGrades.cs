using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.DOMAIN.Models
{
    public class StudentsSubjectGrades
    {
        private long _SGID;
        [Key]
        public long SGID
        {
            get { return _SGID; }
            set { _SGID = value; }
        }


        private DateTime _DateCreated;

        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }

        public long RegNo { get; set; }
        public Students Students { get; set; }

        public long GradeID { get; set; }
        public Grades Grades { get; set; }

        public long SubjectID { get; set; }
        public Subjects Subjects { get; set; }

    }
}
