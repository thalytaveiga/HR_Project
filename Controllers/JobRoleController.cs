using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HR_Project.Services;
using HR_Project.Models;

namespace HR_Project.Controllers
{
    public class JobRoleController : Controller
    {
        private readonly IJobRole _JobRole;
        private readonly IDepartment _Department;

        public JobRoleController(IJobRole _IJobRole, IDepartment _IDepartment)
        {
            _JobRole = _IJobRole;
            _Department = _IDepartment;
        }
        public IActionResult Index()
        {
            return View(_JobRole.GetJobRoles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            JobRole model = new JobRole();
            model.JobId = 0;
            ViewBag.Departments = _Department.GetDepartments;
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(JobRole model)
        {
            if (ModelState.IsValid)
            {
                _JobRole.Add(model);
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
                JobRole model = _JobRole.GetJobRole(Id);
                return View(model);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _JobRole.Remove(Id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? Id)
        {
            var model = _JobRole.GetJobRole(Id);
            ViewBag.Departments = _Department.GetDepartments;
            return View("Create", model);
        }
    }
}