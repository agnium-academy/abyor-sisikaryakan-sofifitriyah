using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sisikaryakan.Models
{
    public class program
    {
        public static void Main(string[] args)
        {
            //managerDrilling drilling = new managerDrilling();
            //managerGeneralAffair generalAffair = new managerGeneralAffair();
            //managerRefinery refinery = new managerRefinery();

            //supervisorDrillingLuwuk drillingluwuk = new supervisorDrillingLuwuk();
            //supervisorDrillingRiau drillingriau = new supervisorDrillingRiau();
            //supervisorRefineryBalikpapan refinerybalikpapan = new supervisorRefineryBalikpapan();

            //staffDrillingLuwuk staffdrillingluwuk = new staffDrillingLuwuk();
            //staffDrillingRiau staffdrillingriau = new staffDrillingRiau();
            //staffRefineryBalikpapan staffrefinerybalikpapan = new staffRefineryBalikpapan();
            //staffGeneralAffair staffgeneralaffair = new staffGeneralAffair();


            managerDrilling tegar = new managerDrilling("Manager Drilling");
            managerDrilling haidar = new managerDrilling("Manager Drilling");
            managerRefinery sani = new managerRefinery("Manager Refinery");
            managerGeneralAffair adi = new managerGeneralAffair("Manager General Affairs");

            supervisorDrillingRiau iqbal = new supervisorDrillingRiau("Supervisor Drilling Riau");
            supervisorDrillingLuwuk ucu = new supervisorDrillingLuwuk("Supervisor Drilling Luwuk");
            supervisorRefineryBalikpapan deni = new supervisorRefineryBalikpapan("Supervisor Refinery Balikpapan");

            staffDrillingRiau dwi = new Staff ("Staff Drilling Riau 1");
            staffDrillingRiau trio = new Staff("Straff Drilling Riau 2");
            staffDrillingLuwuk nuragus = new Staff("Staff Drilling Luwuk");
            staffRefineryBalikpapan sofi = new Staff("Staff Refinery Balikpapan");
            staffGeneralAffair seta = new Staff("Staff General Affairs");

        }
    }
}