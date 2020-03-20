using UnrealBuildTool;

public class FickaTarget : TargetRules
{
	public FickaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Ficka");
	}
}
