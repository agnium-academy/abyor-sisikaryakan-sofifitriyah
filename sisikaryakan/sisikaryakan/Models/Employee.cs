using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class Employee
    {
        [Required]
        public int employeeId { get; set; }

        [Required]
        public string employeeName { get; set; }

        [Required]
        public string gender { get; set; }

        [Required]
        public DateTime birthDate { get; set; }

        [Required]
        public string adress { get; set; }


        [Required]
        public string religion { get; set; }

        [Required]
        public DateTime entryDate { get; set; }

        [Required]
        public string status { get; set; }

        [Required]
        public int basicSalary { get; set; }

        [Required]
        public string phoneNumber { get; set; }
    }
}