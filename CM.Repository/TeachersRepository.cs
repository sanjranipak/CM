using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.DOMAIN.Interfaces;
using CM.DOMAIN.Models;

namespace CM.Repository
{
    public class TeachersRepository : GenericRepository<Teachers>, ITeachersRepository
    {
        public TeachersRepository(CMDbContext cMDbContext) : base(cMDbContext)
        {
        }
    }
}
