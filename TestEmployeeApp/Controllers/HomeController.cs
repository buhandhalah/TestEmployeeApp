using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestEmployeeApp.Helper;
using TestEmployeeApp.Models;

namespace TestEmployeeApp.Controllers
{
    public class HomeController : Controller
    {
        private IntrTaskEntities db = new IntrTaskEntities();
        private CustomConfig helperConfig = new CustomConfig();

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

            var AllEmployeeDetails = db.Employee_Details.ToList();

            model.Employee_DetailsLst = AllEmployeeDetails;

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


        public List<Employee_Details> getAllEmployeesDetails()
        {
            var EmplList = db.Employee_Details.ToList();

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

        [ActionName("DeleteEmployeeDetails")]
        public ActionResult DeleteEmployeeDetails(string File)
        {
            var EmpModel = new Emp_Model();
            if (File != null)
            {
                var findEmployee = db.Employee_Details.Where(m => m.FileName == File).FirstOrDefault();

                if (findEmployee != null)
                {
                    db.Employee_Details.Remove(findEmployee);
                    db.SaveChanges();
                }
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var EmplList = getAllEmployeesDetails();
            EmpModel.Employee_DetailsLst = EmplList;

            return View("EmployeeDetails", EmpModel);
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

        [HttpPost]
        public JsonResult DeleteSupportDoc(string DelFileName, string DelFilePath)
        {
            var delFileName = "";
            var uploadPath = helperConfig.Doc_upload_path;
            bool status = false;
            try
            {

                delFileName = uploadPath + DelFilePath + DelFileName;
                var path = Server.MapPath(delFileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            catch (Exception ex)
            {

                status = false;
            }
            return new JsonResult { Data = new { status = status, relativePath = uploadPath } };
        }

        [HttpPost]
        public JsonResult CreateDetails(Emp_Model emp_Model)
            
        {
            
            bool status = true;

            try
            {
                if(emp_Model != null)
                {
                    if(emp_Model.DocumentsList != null && emp_Model.Employee_Details != null)
                    {
                        var Files = emp_Model.DocumentsList;
                        var Emp = emp_Model.Employee_Details;
                        foreach (var item in Files)
                        {
                            var EmpDetailsNew = new Employee_Details();
                            EmpDetailsNew.FileName = item.FileName;
                            EmpDetailsNew.FilePath = item.FilePath;
                            EmpDetailsNew.EmpId = Emp.EmpId;
                            EmpDetailsNew.CreatedDate = DateTime.Now;

                            db.Employee_Details.Add(EmpDetailsNew);
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                status = false;
            }
            return new JsonResult { Data = new { status = status } };
        }

        [HttpPost]
        public JsonResult uploadSupportFiles()
        {
            var msg = "";
            bool status = false;
            string FileName = "";
            string FilePath = "";
            string origFileName = "";
            string filenameWoExtsn = "";
            string onlyFileName = "";
            string mode = "";
            int? id = null;
            var relativePath = helperConfig.Doc_upload_path;
            mode = Request.Form["mode"];
            id = int.Parse(Request.Form["id"]);

            //List<View_DocServiceSubDoc> savedSubDoc = new List<View_DocServiceSubDoc>();
            List<string> listFileName = new List<string>();
            List<string> listFileNameWOPath = new List<string>();

            if (Request.Files.Count > 0)
            {
                try
                {
                    HttpFileCollectionBase files = Request.Files;
                    for (int i = 0; i < files.Count; i++)
                    {
                        HttpPostedFileBase file = files[i];

                        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                        {
                            string[] testfiles = file.FileName.Split(new char[] { '\\' });
                            FileName = testfiles[testfiles.Length - 1];
                        }
                        else
                        {
                            FileName = file.FileName;
                        }
                        //FileName = helperUtil.MakeValidFileName(FileName);
                        origFileName = FileName;
                        //var fname = Path.GetFileNameWithoutExtension(FileName);

                        var uploadPath = helperConfig.Doc_upload_path;
                        if (uploadPath != "")
                        {
                            uploadPath = isDirectoriesExist(uploadPath, FileName);
                            FileName = uploadPath + FileName;

                            //msg = "File Already Existing!Please rename and attach.";
                            //status = false;
                            filenameWoExtsn = Path.GetFileNameWithoutExtension(FileName);    /* change filename if filename is already existing */
                            var fileExtension = Path.GetExtension(FileName);
                            FileName = uploadPath + filenameWoExtsn + "_" + DateTime.UtcNow.ToString("yyyy_MM_dd_HHmmss", CultureInfo.InvariantCulture) + "_" + i.ToString() + fileExtension;

                            if (System.IO.File.Exists(FileName))
                            {
                                msg = origFileName + " File Already Existing!Please rename and attach.";
                                status = false;
                            }
                            else
                            {
                                file.SaveAs(FileName);
                                status = true;
                            }


                            if (status)    // execute only if uploading is successfull
                            {
                                msg = "File Uploaded Successfully!";
                                string month = DateTime.Now.Month.ToString();
                                string year = DateTime.Now.Year.ToString();
                                FilePath = year + "/" + month + "/";
                                onlyFileName = Path.GetFileName(FileName);      // for passing to delete support file function in doc.js
                                listFileNameWOPath.Add(onlyFileName);
                                listFileName.Add(onlyFileName);
                            }

                            //if (mode == "edit")
                            //{
                            //    savedSubDoc = db.View_DocServiceSubDoc.Where(m => m.DocHeaderID == id).ToList();

                            //}
                        }
                    }
                }
                catch (Exception ex)
                {
                    msg = "Error occurred";
                    status = false;
                }
            }
            else
            {
                msg = "No files selected";
                status = false;
            }
            return new JsonResult { Data = new { status = status, msg = msg, FilePath = FilePath, FileName = listFileName, OnlyFileName = listFileNameWOPath, /*savedSubDoc = savedSubDoc,*/ uploadPath = relativePath } };
        }

        public string isDirectoriesExist(string path, string fileName = null)
        {
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            path = path + year + "/" + month + "/";
            path = Server.MapPath(path);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;

        }

    }
}