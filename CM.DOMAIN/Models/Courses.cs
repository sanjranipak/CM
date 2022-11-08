using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CM.DOMAIN.Models
{
    public class Courses
    {
        #region private fields
        private long _CourseID;
        private string _CourseCode;
        private string _CourseName;
        private string _CourseShortDesc;
        private string _CourseLongDesc;
        private DateTime _DateCreated;
        #endregion
        [Key]
        public long CourseID
        {
            get { return _CourseID; }
            set { this._CourseID = value; }
        }

        public string CourseCode
        {
            get { return _CourseCode; }
            set { this._CourseCode = value; }
        }
        public string CourseName
        {
            get { return _CourseName; }
            set { this._CourseName = value; }
        }
        public string CourseShortDesc
        {
            get { return _CourseShortDesc; }
            set { this._CourseShortDesc = value; }
        }
        public string CourseLongDesc
        {
            get { return _CourseLongDesc; }
            set { this._CourseLongDesc = value; }
        }
        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { this._DateCreated = value; }
        }

        public ICollection<TeachersCourses> TeacherCourse { get; set; }
        public ICollection<CoursesSubject> CoursesSubjects { get; set; }
        //  public ICollection<Students> Student { get; set; }

    }
}
