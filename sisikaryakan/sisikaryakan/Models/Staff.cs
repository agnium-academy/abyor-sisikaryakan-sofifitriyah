﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    class Staff : Employee
    {
        public Staff()
        {

        }

        public Staff(string position)
        {
            this.position = position;
        }
    }
}