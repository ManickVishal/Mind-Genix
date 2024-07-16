using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using static WebApp.Models.student_information;
namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly StudentRepository oStudentrep;
        public readonly IConfiguration oConfiguration;
        public HomeController(ILogger<HomeController> logger, StudentRepository _StudentRepository, IConfiguration _oConfiguration)
        {
            _logger = logger;
            oStudentrep = _StudentRepository;
            oConfiguration = _oConfiguration;
        }
        public IActionResult Index()
        { student_information obj = new student_information();
            obj = oStudentrep.GetStudentDetails();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult StudRegistration()
        {


            student_information ostudent_information=new student_information();

            if (ostudent_information.ostudentRegister == null) ostudent_information.ostudentRegister = new studentRegister();
            ostudent_information = oStudentrep.GetStudentDetails();
            //ostudent_information.ostudentRegister.register_date = DateTime.Now;
            return View(ostudent_information);
        }
        [HttpPost]
        public IActionResult StudRegistration(studentRegister ostudentRegister)
        {
            student_information ostudent_information=new student_information();
            oStudentrep.SaveStudentDetails(ostudentRegister);

            return View(ostudent_information);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
