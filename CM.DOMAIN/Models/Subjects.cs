using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CM.DOMAIN.Models
{
    public class Subjects
    {
        #region Private fields
        private long _SubjectID;
        private string _SubjectCode;
        private string _SubjectName;
        private string _SubjectShortDesc;
        private string _SubjectLongDesc;
        private DateTime _DateCreated;
        #endregion

        [Key]
        public long SubjectID
        {
            get { return _SubjectID; }
            set { this._SubjectID = value; }
        }


        public string SubjectCode
        {
            get { return _SubjectCode; }
            set { this._SubjectCode = value; }
        }

        public string SubjectName
        {
            get { return _SubjectName; }
            set { this._SubjectName = value; }
        }

        public string SubjectShortDesc
        {
            get { return _SubjectShortDesc; }
            set { this._SubjectShortDesc = value; }
        }

        public string SubjectLongDesc
        {
            get { return _SubjectLongDesc; }
            set { this._SubjectLongDesc = value; }
        }
        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { this._DateCreated = value; }
        }

        public ICollection<SubjectsStudents> SubjectsStudents { get; set; }
        public ICollection<StudentsSubjectGrades> StudentsSubjectGrades { get; set; }
   
    }
}
