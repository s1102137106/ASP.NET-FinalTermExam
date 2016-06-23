using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_FinalTermExam.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
         [HttpGet()]
        public ActionResult Index()
        {
            Models.EmployeesService service = new Models.EmployeesService();
            List<Models.EmployeeIndexViewModels> employees = service.GetEmployeeById(4);
            return View(employees);
        }


        /// <summary>
        /// 加入員工
        /// </summary>
        [HttpPost()]
        public ContentResult Create(Models.Employees employee)
        {
            Models.EmployeesService service = new Models.EmployeesService();
            service.Create(employee);
            ContentResult result = new ContentResult();
            result.Content = "新增成功";
            return result;
        }

        [HttpGet()]
        public ActionResult Create()
        {
            return View();
        }


        [HttpGet()]
        public ContentResult Delete(int id)
        {
            Models.EmployeesService service = new Models.EmployeesService();
            service.Delete(id);
            ContentResult result = new ContentResult();
            result.Content = "刪除成功";
            return result;
        }
    }
}