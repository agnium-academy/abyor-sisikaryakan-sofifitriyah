using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class staffGeneralAffair : Employee
    {
        public static implicit operator staffGeneralAffair(Staff v)
        {
            throw new NotImplementedException();
        }
    }
}