using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{   
    
    public class Employee
    {

        public string position;
        public Employee()
        {
        }

        public Employee(string position)
        {
            this.position = position;
        }

        [Required]
        public int employeeId { get; set; }

        [Required]
        public string employeeName { get; set; }

        [Required]
        public string gender { get; set; }

        [Required]
        public DateTime placeOfBirth { get; set; }

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

        public int entryEmployee;


        public int training;


        public string assignment;

        public int layOff;


        public int tunjanganTransportasi;
        
    }

    
}
