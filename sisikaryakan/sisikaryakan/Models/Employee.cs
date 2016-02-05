using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class Employee
    {
        public int employeeId { get; set; }
       
        public string employeeName { get; set; }

        public string gender { get; set; }

        public DateTime birthDate { get; set; }

        public string adress { get; set; }

        public string religion { get; set; }

        public DateTime entryDate { get; set; }

        public string status { get; set; }

        public int basicSalary { get; set; }

        public string phoneNumber { get; set; }
    }
}