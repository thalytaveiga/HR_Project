using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HR_Project.Services;
using HR_Project.Models;

namespace HR_Project.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _Employee;
        private readonly IDepartment _Department;
        private readonly IJobRole _JobRole;

        public EmployeeController(IEmployee _IEmployee, IDepartment _IDepartment, IJobRole _IJobRole)
        {
            _Employee = _IEmployee;
            _Department = _IDepartment;
            _JobRole = _IJobRole;
        }
        public IActionResult Index()
        {
            return View(_Employee.GetEmployees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Employee model = new Employee();
            model.EmpId = 0;
            ViewBag.Departments = _Department.GetDepartments;
            ViewBag.JobRoles = _JobRole.GetJobRoles;
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                _Employee.Add(model);
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
                Employee model = _Employee.GetEmployee(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Employee.Remove(Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            return View(_Employee.GetEmployee(Id));
        }

        public IActionResult Edit(int? Id)
        {
            var model = _Employee.GetEmployee(Id);
            ViewBag.Departments = _Department.GetDepartments;
            ViewBag.JobRoles = _JobRole.GetJobRoles;
            return View("Create", model);
        }
    }
}