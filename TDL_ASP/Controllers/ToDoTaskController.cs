using Microsoft.AspNetCore.Mvc;
using TDL_ASP.Data;
using TDL_ASP.Models;

namespace TDL_ASP.Controllers
{
    public class ToDoTaskController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ToDoTaskController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ToDoTask> objToDoTaskList = _db.Tasks;
            return View(objToDoTaskList);
        }
    }
}
