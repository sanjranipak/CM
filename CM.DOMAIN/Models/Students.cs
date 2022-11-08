using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CM.DOMAIN.Models
{

    public class Students
    {
        #region private fields
        private long _RegNo;
        private string _Name;
        private DateTime _DOB;
        private DateTime _DateCreated;
        #endregion
        [Key]
        public long RegNo
        {
            get { return _RegNo; }
            set { this._RegNo = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { this._Name = value; }
        }
        public DateTime DOB
        {
            get { return _DOB; }
            set { this._DOB = value; }
        }

        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { this._DateCreated = value; }
        }


        public ICollection<SubjectsStudents> SubjectsStudents { get; set; }

        public ICollection<StudentsSubjectGrades> StudentsGrades { get; set; }
    }
}
