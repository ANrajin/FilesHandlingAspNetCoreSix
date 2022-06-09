using Microsoft.AspNetCore.Mvc;

namespace FilesHandling.Test.Controllers
{
    public class FilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
