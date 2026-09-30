using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    abstract class RobotPrototype
    {
        public string ModelName;
        public int BatteryLevel;
        public string softwareVersion;

        public RobotPrototype(string modelName, int batteryLevel, string softwareVersion)
        {
            this.ModelName = modelName;
            this.BatteryLevel = batteryLevel;
            this.softwareVersion = softwareVersion;
        }
        public abstract RobotPrototype Clone();
        public abstract void DisplayInfo();
    }
}
