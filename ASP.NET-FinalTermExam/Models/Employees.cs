namespace ASP.NET_FinalTermExam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.Employees")]
    public partial class Employees
    {
        public Employees()
        {
            Employees1 = new HashSet<Employees>();
        }

        [Key]
        [DisplayName("訂單編號")]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("姓名(Last Name)")]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("姓名(First Name)")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        [DisplayName("職稱")]
        public string Title { get; set; }

        [Required]
        [StringLength(25)]
        [DisplayName("稱謂")]
        public string TitleOfCourtesy { get; set; }

        [DisplayName("生日")]
        public DateTime BirthDate { get; set; }

        [DisplayName("任職日期")]
        public DateTime HireDate { get; set; }

        [Required]
        [StringLength(60)]
        [DisplayName("地址")]
        public string Address { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("城市")]
        public string City { get; set; }

        [StringLength(15)]
        [DisplayName("地區")]
        public string Region { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("國家")]
        public string Country { get; set; }

        [Required]
        [StringLength(24)]
        [DisplayName("電話")]
        public string Phone { get; set; }

        [DisplayName("直屬主管")]
        public int? ManagerID { get; set; }

        [StringLength(2)]
        [DisplayName("性別")]
        public string Gender { get; set; }

        [DisplayName("月薪")]
        public int? MonthlyPayment { get; set; }

        [DisplayName("年薪")]
        public int? YearlyPayment { get; set; }

        public virtual ICollection<Employees> Employees1 { get; set; }

        public virtual Employees Employees2 { get; set; }
    }
}
