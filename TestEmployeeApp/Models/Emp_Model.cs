using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestEmployeeApp.Models
{
    public class Emp_Model
    {
        public Employee Employee { get; set; }
        public Employee_Details Employee_Details { get; set; }

        public List<Employee> Employeeslst { get; set; }
        public List<Employee_Details> Employee_DetailsLst { get; set; }

        public View_EmpDetails View_EmpDetails { get; set; }
        public List<View_EmpDetails> View_EmpDetailsLst { get; set; }

        public IEnumerable<SelectListItem> EmployeeItems
        {
            get
            { return new SelectList(Employeeslst, "EmpId", "Name"); }
        }

    }
}