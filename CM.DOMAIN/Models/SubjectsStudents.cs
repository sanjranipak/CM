using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CM.DOMAIN.Models
{
    public class SubjectsStudents
    {

        private long _SSID;
        [Key]
        public long SSID
        {
            get { return _SSID; }
            set { _SSID = value; }
        }

        
        
        private DateTime _DateCreated;

        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }

        #region Key
        public long SubjectID { get; set; }
        public Subjects Subjects { get; set; }

        public long RegNo { get; set; }
        public Students Students { get; set; }
        #endregion
    }
}
