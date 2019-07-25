using UnrealBuildTool;

public class Demo_spectTarget : TargetRules
{
	public Demo_spectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Demo_spect");
	}
}
