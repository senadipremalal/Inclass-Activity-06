using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    public class EntertainmentRobot : RobotPrototype
    {
        public string EntertainmentType;

        public EntertainmentRobot(string modelName, int batteryLevel, string softwareVersion, string entertainmentType) : base(modelName, batteryLevel, softwareVersion)
        {
            EntertainmentType = entertainmentType;
        }

        public override RobotPrototype Clone()
        {
            return new EntertainmentRobot(this.ModelName, this.BatteryLevel, this.softwareVersion, this.EntertainmentType);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Entertainment Robot - Model: {ModelName}, Battery Level: {BatteryLevel}%, Software Version: {softwareVersion}, Entertainment Type: {EntertainmentType}");
        }
    }
}
