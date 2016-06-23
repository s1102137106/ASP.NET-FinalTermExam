using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ASP.NET_FinalTermExam.Models
{
    public class EmployeeIndexViewModels
    {
        public int EmployeeID { get; set; }

        public string LastName { get; set; }


        public string FirstName { get; set; }

        public string Title { get; set; }

        public DateTime HireDate { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public int age { get; set; }
        

        
        

        // x.EmployeeID, x.FirstName, x.LastName, x.Title, x.HireDate, x.Gender, x.BirthDate
    }
}