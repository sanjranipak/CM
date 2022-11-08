using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CM.DOMAIN.Interfaces;
using CM.DOMAIN.Models;
using CM.Repository;


namespace CM.Controllers
{
    public class HomeController : Controller
    {
        private IGenericRepository<Courses> repository = null;
        private IGenericRepository<Students> studentRepo = null;
        private IGenericRepository<Teachers> TeacherRepo = null;
        private IGenericRepository<TeachersCourses> TeachersCoursesRepo = null;
        private IGenericRepository<Subjects> SubjectsRepo = null;
        private IGenericRepository<Grades> GradesRepo = null;
        

        public HomeController()
        {
            this.repository = new GenericRepository<Courses>();
            this.studentRepo = new GenericRepository<Students>();
            this.TeacherRepo = new GenericRepository<Teachers>();
            this.SubjectsRepo = new GenericRepository<Subjects>();
            this.GradesRepo = new GenericRepository<Grades>();
            this.TeachersCoursesRepo = new GenericRepository<TeachersCourses>();
        }
        public HomeController(IUnitOfWork unitWork)
        {
           // _Iunitwork = unitWork;
        }
        
        public   ActionResult Index()
        {
            Subjects _addSubject = new Subjects();
            _addSubject.SubjectName = "S1";
            _addSubject.DateCreated = DateTime.Now;
            SubjectsRepo.Insert(_addSubject);
            SubjectsRepo.Save();


            Students _addStudent = new Students();
            _addStudent.Name = "test";
            _addStudent.DOB = DateTime.Now;
            _addStudent.DateCreated = DateTime.Now;
            studentRepo.Insert(_addStudent);
            studentRepo.Save();

            Teachers _addTeacher = new Teachers();
            _addTeacher.Name = "test";
            _addTeacher.Salary = 2000;
            _addTeacher.DateCreated = DateTime.Now;
            TeacherRepo.Insert(_addTeacher);
            TeacherRepo.Save();

            //;

            Courses _addCourse = new Courses();
            _addCourse.CourseCode = "abc";
            _addCourse.DateCreated = DateTime.Now;
            repository.Insert(_addCourse);
            repository.Save();



            return View();
        }
 
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}