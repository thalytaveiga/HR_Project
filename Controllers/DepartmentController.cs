using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HR_Project.Services;
using HR_Project.Models;

namespace HR_Project.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartment _Department;
        private readonly IEmployee _Employee;
        private readonly IJobRole _JobRole;

        public DepartmentController(IDepartment _IDepartment, IEmployee _IEmployee, IJobRole _IJobRole)
        {
            _Employee = _IEmployee;
            _Department = _IDepartment;
            _JobRole = _IJobRole;
        }
        public IActionResult Index()
        {
            return View(_Department.GetDepartments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Department model = new Department();
            model.DeptId = 0;
            ViewBag.JobRoles = _JobRole.GetJobRoles;
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Department model)
        {
            if (ModelState.IsValid)
            {
                _Department.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                Department model = _Department.GetDepartment(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Department.Remove(Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            return View(_Department.GetDepartment(Id));
        }

        public IActionResult Edit(int? Id)
        {
            var model = _Department.GetDepartment(Id);
            return View("Create", model);
        }
    }
}