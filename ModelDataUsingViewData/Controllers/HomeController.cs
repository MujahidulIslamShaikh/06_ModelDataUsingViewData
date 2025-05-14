using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;
using ModelDataUsingViewData.Repository;

namespace ModelDataUsingViewData.Controllers
{
    //[Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly EmployeeRepository _EmployeeRepository; // add referance variable

        public HomeController(ILogger<HomeController> logger, EmployeeRepository employeeRepository)
        {
            _logger = logger;
            _EmployeeRepository = employeeRepository;
        }
        public IActionResult EmployeeListData()
        {
            List<Employee> empListData = _EmployeeRepository.getAllEmployee();
            return View(empListData);
        }
        public IActionResult StronglyTypedViews()
        {
            Employee emp = new Employee()
            {
                EmpId = 1001,
                EmpName = "Mujahid",
                Designation = "Manager",
                Salary = 25000
            };
            return View(emp);
        }
        public IActionResult StudentForm()
        {
            return View();
        }
        [HttpPost]
        //[Route("Home/StudentForm")]
        public IActionResult StudentForm(Student std)
        {
            //return std.Name;
            return View(std);
        }

        public IActionResult Index()
        {
            Employee emp = new Employee() 
            {
                EmpId = 1001,
                EmpName = "Mujahid",
                Designation = "Manager",
                Salary = 25000,
            };
            ViewData["myEmployee"] = emp;
            ViewBag.myEmpData = emp;
            TempData["myEmployee"] = emp;

            return View();
        }

        public IActionResult Privacy()
        {
            var myEmployee = new List<Employee>
            {
                new Employee { EmpId=101,EmpName="Sahil",Designation="Manager",Salary=25000},
                new Employee { EmpId=102,EmpName="Mujahid",Designation="Developer",Salary=25000},
                new Employee { EmpId=103,EmpName="Zubair",Designation="Programmer",Salary=25000}
            };
            ViewData["empData"] = myEmployee;
            //ViewBag.empData = myEmployee;
            //TempData["empData"] = myEmployee;
            return View();
        }
        //[Route("CheckBox")]
        //public IActionResult CheckBox()
        //{
            
        //    var model = new CheckModel()
        //    {
        //        AcceptTerms = false,
        //        Text = "I accept the terms.",
        //        UserName = "Mujahid",
        //        Age = 22,
        //        Cont_number = 7350441912
        //    };
        //    return View(model);
        //}
        public IActionResult CheckBox()
        {
            var model = new CheckModel()
            {
                CheckBoxes = new List<SingleCheckBoxModel>
                {
                    new SingleCheckBoxModel()
                    {
                        IsChecked = true,
                        Text = "Cricket",
                        Value = "Cricket"
                    },
                    new SingleCheckBoxModel()
                    {
                        IsChecked = false,
                        Text = "Football",
                        Value = "Football"
                    },
                    new SingleCheckBoxModel()
                    {
                        IsChecked = false,
                        Text = "Hocky",
                        Value = "Hocky"
                    }
                }     
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult CheckBox(CheckModel data)
        {
            //var value = data.AcceptTerms;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
