using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class staffDrillingLuwuk : Employee
    {
        public static implicit operator staffDrillingLuwuk(Staff v)
        {
            throw new NotImplementedException();
        }
    }
}