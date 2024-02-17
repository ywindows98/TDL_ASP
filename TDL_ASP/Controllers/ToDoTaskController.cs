using Microsoft.AspNetCore.Mvc;

namespace TDL_ASP.Controllers
{
    public class ToDoTaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
