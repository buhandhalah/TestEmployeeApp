using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestEmployeeApp.Models;

namespace TestEmployeeApp.Controllers
{
    public class HomeController : Controller
    {
        private IntrTaskEntities db = new IntrTaskEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Employee()
        {
            var model = new Emp_Model();

            var AllEmployees = getAllEmployees();

            model.Employeeslst = AllEmployees;

            return View(model);
        }

        public ActionResult EmployeeDetails()
        {
            var model = new Emp_Model();

            var AllEmployeeDetails = db.View_EmpDetails.ToList();

            model.View_EmpDetailsLst = AllEmployeeDetails;

            return View(model);
        }

        public ActionResult CreateEmployee()
        {
            // var model = new Emp_Model();

            return View();
        }

        [HttpPost]
        public ActionResult CreateEmployee(Employee employee)
        {
            var EmpModel = new Emp_Model();
            var model = new Employee();
            var EmplList = new List<Employee>();
            if (employee != null)
            {
                if (employee.Name != null)
                {
                    model.Name = employee.Name;
                }
                if (employee.Designation != null)
                {
                    model.Designation = employee.Designation;
                }
                if (employee.Email != null)
                {
                    model.Email = employee.Email;
                }

                db.Employee.Add(model);
                db.SaveChanges();
            }

            EmplList = getAllEmployees();
            EmpModel.Employeeslst = EmplList;

            return View("Employee", EmpModel);
        }

        public List<Employee> getAllEmployees()
        {
            var EmplList = db.Employee.ToList();

            return EmplList;
        }

        [ActionName("DeleteEmployee")]
        public ActionResult DeleteEmployee(long? id)
        {
            var EmpModel = new Emp_Model();
            if (id != null)
            {
                var findEmployee = db.Employee.Where(m => m.EmpId == id).FirstOrDefault();

                if (findEmployee != null)
                {
                    db.Employee.Remove(findEmployee);
                    db.SaveChanges();
                }
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var EmplList = getAllEmployees();
            EmpModel.Employeeslst = EmplList;

            return View("Employee", EmpModel);
        }


        public ActionResult EditEmployee(long? id)
        {
            var EmpModel = new Emp_Model();
            if (id != null)
            {
                var findEmployee = db.Employee.Where(m => m.EmpId == id).FirstOrDefault();

                if (findEmployee != null)
                {
                    EmpModel.Employee = findEmployee;
                }
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var EmplList = getAllEmployees();
            EmpModel.Employeeslst = EmplList;

            return View(EmpModel);
        }

        [HttpPost]
        public ActionResult EditEmployee(Employee employee)
        {
            var EmpModel = new Emp_Model();
            var model = new Employee();
            var EmplList = new List<Employee>();
            
            if (employee != null)
            {
                long? id = employee.EmpId;

                var FindEmp = db.Employee.Where(m => m.EmpId == id).FirstOrDefault();

                if (FindEmp != null)
                {
                    if (employee.Name != null)
                    {
                        FindEmp.Name = employee.Name;
                    }
                    if (employee.Designation != null)
                    {
                        FindEmp.Designation = employee.Designation;
                    }
                    if (employee.Email != null)
                    {
                        FindEmp.Email = employee.Email;
                    }
                }

                //db.Employee.Add(model);
                db.SaveChanges();
            }

            EmplList = getAllEmployees();
            EmpModel.Employeeslst = EmplList;

            return View("Employee", EmpModel);
        }

        public ActionResult CreateEmployeeDetails()
        {
            var model = new Emp_Model();
            var AllEmployees = db.Employee.ToList();

            model.Employeeslst = AllEmployees;

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}