using UnrealBuildTool;

public class Projet_Saison_2Target : TargetRules
{
	public Projet_Saison_2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Projet_Saison_2");
	}
}
