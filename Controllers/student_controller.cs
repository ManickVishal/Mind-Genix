using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
public class StudentController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Register(student_information ostudentRegister)
    {
        if (ModelState.IsValid)
        {
            // Save the student to the database or perform other actions
            // For simplicity, let's assume we are just displaying the student details
            return View("RegistrationSuccess", ostudentRegister);
        }

        // If the model state is not valid, return to the registration page
        return View("Index", ostudentRegister);
    }
}