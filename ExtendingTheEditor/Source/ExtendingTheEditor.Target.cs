// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ExtendingTheEditorTarget : TargetRules
{
	public ExtendingTheEditorTarget(TargetInfo Target) : base (Target)
	{
		Type = TargetType.Game;
		
		ExtraModuleNames.AddRange( new string[] {"ExtendingTheEditor"});
	}
	
	

	//
	// TargetRules interface.
	//
/*
	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.Add("ExtendingTheEditor");
	}
	*/
}
