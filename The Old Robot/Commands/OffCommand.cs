class OffCommand : RobotCommand
{
    public override void Run(Robot robot) => robot.IsPowered = false;
}