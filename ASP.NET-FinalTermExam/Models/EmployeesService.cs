using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_FinalTermExam.Models
{
    public class EmployeesService
    {

        /// <summary>
        /// 依照條件取得員工資料
        /// </summary>
        /// <returns></returns>
        public List<EmployeeIndexViewModels> GetEmployeeById(int id)
        {
            Db db = new Db();
            var result = db.Employees.Select(x => new { x.EmployeeID, x.FirstName, x.LastName, x.Title, x.HireDate, x.Gender, x.BirthDate }).ToList();


            List<EmployeeIndexViewModels> ListEmployees = new List<EmployeeIndexViewModels>();
            foreach (var employee in result)
            {


                #region 生日計算
                DateTime birthDate = employee.BirthDate;
                DateTime dts = birthDate;
                DateTime dte = DateTime.Now;
                int ageYear = 0, ageMonth = 0, ageDay = 0, cumMonth = 0;
                DateTime dtw = dts;
                while (dtw <= dte)
                {
                    dtw = dtw.AddMonths(1);
                    cumMonth++;
                }
                dtw = dtw.AddMonths(-1);
                ageYear = cumMonth / 12;
                ageMonth = cumMonth % 12;
                ageDay = Convert.ToInt16((dte - dtw).TotalDays);
                #endregion

                EmployeeIndexViewModels viewTemp = new EmployeeIndexViewModels
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Gender = employee.Gender,
                    BirthDate = employee.BirthDate,
                    EmployeeID = employee.EmployeeID,
                    HireDate = employee.HireDate,
                    Title = employee.Title,
                    age = ageYear

                };
                ListEmployees.Add(viewTemp);
            }

            return ListEmployees;
        }

        /// <summary>
        /// 刪除員工資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Delete(int employeeId)
        {
            
            using (Db db = new Db())
            {
                var deleteRow = db.Employees.Find(employeeId);
                db.Employees.Remove(deleteRow);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 新增員工資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Create(Employees employee)
        {

            using (Db db = new Db())
            {
                int max = db.Employees.Select(x => x.EmployeeID).Max();
                employee.EmployeeID = max + 1;
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }
    }
}