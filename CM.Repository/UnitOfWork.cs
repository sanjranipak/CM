using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.DOMAIN.Interfaces;

namespace CM.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CMDbContext _cMDbContext;
        public ICoursesRepository Courses { get; }

        public IGradesReporsitory Grade { get; }

        public IStudentsRepository Student { get; }

        public ISubjectsRepository Subjects { get; }

        public ITeachersRepository Teachers { get; }

        public UnitOfWork(CMDbContext _Context, ICoursesRepository coursesRepository
            , IGradesReporsitory gradesReporsitory, IStudentsRepository studentsRepository
            , ISubjectsRepository subjectsRepository, ITeachersRepository teachersRepository)
        {
            this._cMDbContext = _Context;
            this.Courses = coursesRepository;
            this.Grade = gradesReporsitory;
            this.Student = studentsRepository;
            this.Subjects = subjectsRepository;
            this.Teachers = teachersRepository;

        }

        public int Complete()
        {
            return _cMDbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _cMDbContext.Dispose();
            }
        }
    }
}
