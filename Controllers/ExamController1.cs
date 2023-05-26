using Microsoft.AspNetCore.Mvc;

namespace ExamMVC.Controllers
{
    public class ExamController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
