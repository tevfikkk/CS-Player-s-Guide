class OnCommand : RobotCommand
{
    public override void Run(Robot robot) => robot.IsPowered = true;
}