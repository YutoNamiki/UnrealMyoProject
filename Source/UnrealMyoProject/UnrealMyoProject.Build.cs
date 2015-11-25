// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnrealMyoProject : ModuleRules
{
	public UnrealMyoProject(TargetInfo Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "MyoPlugin" });
        PublicIncludePathModuleNames.AddRange(new string[] { "MyoPlugin" });
        PrivateDependencyModuleNames.AddRange(new string[] { "MyoPlugin" });
        PrivateIncludePathModuleNames.AddRange(new string[] { "MyoPlugin" });
	}
}
