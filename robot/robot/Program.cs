using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot sRobot=new ServiceRobot("ServiceBot-1000", 80, "v1.2.3", "Cleaning");
            sRobot.DisplayInfo();

            IndustrialRobot iRobot = new IndustrialRobot("IndustrialBot-2000", 90, "v2.0.0", "Assembly");
            iRobot.DisplayInfo();

            EntertainmentRobot eRobot = new EntertainmentRobot("EntertainmentBot-3000", 75, "v1.5.0", "Gaming");
            eRobot.DisplayInfo();
        }
    }
}
