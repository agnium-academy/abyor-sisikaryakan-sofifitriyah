using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{

    
    class Manager : Supervisor
    {
        public int tunjanganHariRaya;
        public int studiBanding;
        public int tunjanganKesehatan;

        public Manager()
        {

        }

        public Manager(string position)
        {
            this.position = position;
        }

    }
}