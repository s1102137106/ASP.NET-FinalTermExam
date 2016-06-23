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
        [DisplayName("�q��s��")]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("�m�W(Last Name)")]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("�m�W(First Name)")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        [DisplayName("¾��")]
        public string Title { get; set; }

        [Required]
        [StringLength(25)]
        [DisplayName("�ٿ�")]
        public string TitleOfCourtesy { get; set; }

        [DisplayName("�ͤ�")]
        public DateTime BirthDate { get; set; }

        [DisplayName("��¾���")]
        public DateTime HireDate { get; set; }

        [Required]
        [StringLength(60)]
        [DisplayName("�a�}")]
        public string Address { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("����")]
        public string City { get; set; }

        [StringLength(15)]
        [DisplayName("�a��")]
        public string Region { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("��a")]
        public string Country { get; set; }

        [Required]
        [StringLength(24)]
        [DisplayName("�q��")]
        public string Phone { get; set; }

        [DisplayName("���ݥD��")]
        public int? ManagerID { get; set; }

        [StringLength(2)]
        [DisplayName("�ʧO")]
        public string Gender { get; set; }

        [DisplayName("���~")]
        public int? MonthlyPayment { get; set; }

        [DisplayName("�~�~")]
        public int? YearlyPayment { get; set; }

        public virtual ICollection<Employees> Employees1 { get; set; }

        public virtual Employees Employees2 { get; set; }
    }
}
