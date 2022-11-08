using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CM.DOMAIN.Models
{
    public class Grades
    {
        private long _GradeID;
        private string _grade;
        private DateTime _DateCreated;

        [Key]
        public long GradeID
        {
            get { return _GradeID; }
            set { this._GradeID = value; }
        }
       
        public string grade
        {
            get { return _grade; }
            set { this._grade = value; }
        }
       
        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { this._DateCreated = value; }
        }

        public ICollection<StudentsSubjectGrades> StudentGrade { get; set; } 
    }
}
