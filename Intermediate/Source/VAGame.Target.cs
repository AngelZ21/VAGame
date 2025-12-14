using UnrealBuildTool;

public class VAGameTarget : TargetRules
{
	public VAGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("VAGame");
	}
}
