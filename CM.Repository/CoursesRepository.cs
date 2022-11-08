using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.DOMAIN.Models;
using CM.DOMAIN.Interfaces;

namespace CM.Repository
{
    public class CoursesRepository : GenericRepository<Courses> , ICoursesRepository
    {
        public CoursesRepository(CMDbContext cMDbContext) : base(cMDbContext)
        {

        }


    }
}
