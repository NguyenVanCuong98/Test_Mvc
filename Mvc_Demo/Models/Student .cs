using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Demo.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DisplayName("Mã số Sinh viên")]
        public int PStudentID { get; set; }

        [DisplayName("Tên sinh viên")]
        public string StudentName { get; set; }
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
    }
}
