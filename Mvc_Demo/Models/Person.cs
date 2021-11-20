using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Demo.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [DisplayName("Người thứ")]
        public string PersonID { get; set; }

        [DisplayName("Tên")]
        public string PersonName { get; set; }
    }
}
