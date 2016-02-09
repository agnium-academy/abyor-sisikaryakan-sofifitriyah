using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class staffDrillingRiau : Employee
    {
        public static implicit operator staffDrillingRiau(Staff v)
        {
            throw new NotImplementedException();
        }
    }
}