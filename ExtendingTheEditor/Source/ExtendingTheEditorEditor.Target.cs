// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ExtendingTheEditorEditorTarget : TargetRules
{
	public ExtendingTheEditorEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		
		ExtraModuleNames.Add("ExtendingTheEditor");
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
