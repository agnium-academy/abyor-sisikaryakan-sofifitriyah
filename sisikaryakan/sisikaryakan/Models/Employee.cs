using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{   
    
    abstract class Employee
    {
        public string name;
        public string position;
        public DateTime entryDate;
        public string training;
        public string assignment;
        public string layOff;
        public int basicSalary;
        public int tunjanganTransportasi;


               
    }

    
}
