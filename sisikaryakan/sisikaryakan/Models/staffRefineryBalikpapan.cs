using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class staffRefineryBalikpapan : Employee
    {
        public static implicit operator staffRefineryBalikpapan(Staff v)
        {
            throw new NotImplementedException();
        }
    }
}