// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RunnerGame : ModuleRules
{
	public RunnerGame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] 
		{ 
			"Core", 
			"CoreUObject",
			"Engine", 
			"InputCore" 
		});
		PrivateDependencyModuleNames.AddRange(new string[] 
		{
			"Slate",
			"SlateCore",
			"OnlineSubsystem",
			"OnlineSubsystemSteam" 
		});
		PublicIncludePaths.Add(ModuleDirectory);
	}
}
