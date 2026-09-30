using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    public class ServiceRobot : RobotPrototype
    {
        public string ServiceType;

        public ServiceRobot(string modelName, int batteryLevel, string softwareVersion, string serviceType) : base(modelName, batteryLevel, softwareVersion)
        {
            ServiceType = serviceType;
        }

        public override RobotPrototype Clone()
        {
            return new ServiceRobot(this.ModelName, this.BatteryLevel, this.softwareVersion, this.ServiceType);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Service Robot - Model: {ModelName}, Battery Level: {BatteryLevel}%, Software Version: {softwareVersion}, Service Type: {ServiceType}");
        }
    }
}
