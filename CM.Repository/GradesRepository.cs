using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.DOMAIN.Interfaces;
using CM.DOMAIN.Models;

namespace CM.Repository
{
    public class GradesRepository : GenericRepository<Grades> , IGradesReporsitory
    {
        public GradesRepository(CMDbContext cMDbContext) : base(cMDbContext)
        {

        }
    }
}
