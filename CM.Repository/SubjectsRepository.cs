using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.DOMAIN.Interfaces;
using CM.DOMAIN.Models;

namespace CM.Repository
{
    public class SubjectsRepository : GenericRepository<Subjects>, ISubjectsRepository
    {
        public SubjectsRepository(CMDbContext cMDbContext) : base(cMDbContext)
        {

        }
    }
}
