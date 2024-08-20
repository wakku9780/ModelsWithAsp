using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Models.Repository;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace Models.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository=null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }
        public List<StudentModel> getAllStudents() {
            return _studentRepository.getAllStudents();

        }

        public StudentModel getById(int id)
        {
            return _studentRepository.getStudentById(id);        }
        public IActionResult Index()
        {
            //var student = new List<StudentModel>
            //{
            //    new StudentModel{ rollNo = 1, name = "waqar", gender = "Male", standard = 12 },
            //    new StudentModel{ rollNo = 2, name = "natasha", gender = "Female", standard = 13 },
            //    new StudentModel{ rollNo = 3, name = "azeem", gender = "Male", standard = 14 },
            //    new StudentModel{ rollNo = 4, name = "abdul", gender = "Male", standard = 15 },
            //    new StudentModel{ rollNo = 5, name = "akhir", gender = "Male", standard = 12 },
            //    new StudentModel{ rollNo = 6, name = "hozaifa", gender = "Male", standard = 11 },
            //};

            //ViewData["myStudents"] = student;

            //Employee emp = new Employee()
            //{
            //    empId = 101,
            //    empName = "waqar",
            //    designation = "developer",
            //    salary = 100000
            //};

            //ViewData["myEmployee"] = emp;

            var myEmployees = new List<Employee>
            {  new Employee{empId=101,empName="saswat",designation="developer",salary=100234},
            new Employee{empId=102,empName="azeem",designation="java developer",salary=20000},
            new Employee{empId=103,empName="saif",designation="Accountant",salary=25000},


            };

            ViewData["myEmployee"] = myEmployees;





            return View();
        }

        public IActionResult Privacy()
        {

            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
