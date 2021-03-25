using Robocode;

namespace Sabor.X
{
    public class GiantDeathRobot : Robot 
    {
        public override void Run()
        {
            TurnLeft(Heading - 90);
            TurnGunRight(90);

            while (true)
            {
                Ahead(5000);

                TurnRight(90);
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            Fire(1);
        }
    }
}
