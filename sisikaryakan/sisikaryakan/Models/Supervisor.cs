using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class Supervisor : Employee
    {

        public int tunjanganPenginapan;
        public int tunjanganInternet;

        public Supervisor()
        {
        }

        public Supervisor(string position)
        {
            this.position = position;
        }
    }
}