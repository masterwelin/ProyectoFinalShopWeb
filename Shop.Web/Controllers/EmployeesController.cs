using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Web.Data.Dtos;
using Shop.Web.Data.Interfaces;

namespace Shop.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployees employeesDb;
        public EmployeesController(IEmployees employeesDb) 
        {
            this.employeesDb = employeesDb;            
        }

        public ActionResult Index()
        {
            var employees = this.employeesDb.GetEmployees();
            return View(employees);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            var employees = this.employeesDb.GetEmployeesById(id);
            return View(employees);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeesAddDto addDto)
        {
            try
            {
                addDto.creation_date = DateTime.Now;
                addDto.creation_user = 2;
                this.employeesDb.SaveEmployees(addDto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            var employees = this.employeesDb.GetEmployeesById(id);
            return View(employees);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeesUpdateDto updateDto)
        {
            try
            {
                updateDto.modify_date = DateTime.Now;
                updateDto.modify_user = 2;
                this.employeesDb.UpdateEmployees(updateDto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
