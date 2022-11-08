using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.DOMAIN.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICoursesRepository Courses { get;  }
        IGradesReporsitory Grade { get;  }
        IStudentsRepository Student { get;  }
        ISubjectsRepository Subjects { get;  }
        ITeachersRepository Teachers { get; }

        int Complete();
    }
}
