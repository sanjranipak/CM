using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using CM.DOMAIN.Interfaces;

namespace CM.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<ICoursesRepository, CoursesRepository>();
            services.AddTransient<IGradesReporsitory, GradesRepository>();
            services.AddTransient<IStudentsRepository, StudentsRepository>();
            services.AddTransient<ISubjectsRepository, SubjectsRepository>();
            services.AddTransient<ITeachersRepository, TeachersRepository>();
             
            return services;
        }
    }
}
