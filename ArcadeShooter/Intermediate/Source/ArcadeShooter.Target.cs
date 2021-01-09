using UnrealBuildTool;

public class ArcadeShooterTarget : TargetRules
{
	public ArcadeShooterTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ArcadeShooter");
	}
}
