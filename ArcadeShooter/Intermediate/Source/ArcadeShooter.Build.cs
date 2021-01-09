using UnrealBuildTool;

public class ArcadeShooter : ModuleRules
{
	public ArcadeShooter(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
