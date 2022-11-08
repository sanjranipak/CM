using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CM.DOMAIN.Models
{
    public class Teachers
    {
        #region Private fields 

        private long _TeacherID;
        private string _Name;
        private decimal _Salary;
        private DateTime _DateCreated;
        #endregion

        [Key]
        public long TeacherID
        {
            get { return _TeacherID; }
            set { this._TeacherID = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { this._Name = value; }
        }
        public decimal Salary
        {
            get { return _Salary; }
            set { this._Salary = value; }
        }




        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { this._DateCreated = value; }
        }

        public ICollection<TeachersCourses> TeachersCourses { get; set; }

    }
}
