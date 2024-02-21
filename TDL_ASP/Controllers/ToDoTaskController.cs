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

        public IActionResult Details()
        {
            IEnumerable<ToDoTask> objToDoTaskList = _db.Tasks;
            return View(objToDoTaskList);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ToDoTask task)
        {
            if(task.Name == task.Description)
            {
                ModelState.AddModelError("SameNameDescription", "Description can not be the same as name."); // key, value
                ModelState.AddModelError("name", "Name value cannot be accepted."); // name/ Name key will change the error in this case
            }
            //ModelState.AddModelError("name", "Name value cannot be accepted."); // wont work
            if (ModelState.IsValid)
            {
                
                _db.Tasks.Add(task);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(task);
        }


        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var taskEntity = _db.Tasks.Find(id);

            if(taskEntity == null)
            {
                return NotFound();
            }

            return View(taskEntity);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ToDoTask task)
        {
            if (task.Name == task.Description)
            {
                ModelState.AddModelError("SameNameDescription", "Description can not be the same as name."); // key, value
                ModelState.AddModelError("name", "Name value cannot be accepted."); // name/ Name key will change the error in this case
            }
            //ModelState.AddModelError("name", "Name value cannot be accepted."); // wont work
            if (ModelState.IsValid)
            {

                _db.Tasks.Update(task);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(task);
        }
    }
}
