using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Demo.Models
{
    public class People:Person
    {
        public int PeopleID { get; set; }


        public string PeopleName { get; set; }
        public int Age { get; set; }
    }
}
