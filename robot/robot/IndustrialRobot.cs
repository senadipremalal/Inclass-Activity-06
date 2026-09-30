using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot
{
    public class IndustrialRobot : RobotPrototype
    {
        public string IndustrialTask;

        public IndustrialRobot(string modelName, int batteryLevel, string softwareVersion, string industrialTask) : base(modelName, batteryLevel, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        public override RobotPrototype Clone()
        {
            return new IndustrialRobot(this.ModelName, this.BatteryLevel, this.softwareVersion, this.IndustrialTask);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Industrial Robot - Model: {ModelName}, Battery Level: {BatteryLevel}%, Software Version: {softwareVersion}, Industrial Task: {IndustrialTask}");
        }
    }
}
