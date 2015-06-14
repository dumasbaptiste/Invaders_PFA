// Copyright 1998-2014 Epic Games, Inc. All Rights Reserved.
 
using UnrealBuildTool;
using System.Collections.Generic;
 
public class Invaders_EIPServerTarget : TargetRules
{
    public Invaders_EIPServerTarget(TargetInfo Target)
    {
        Type = TargetType.Server;
    }
 
    //
    // TargetRules interface.
    //

    public override void SetupBinaries(
        TargetInfo Target,
        ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
        ref List<string> OutExtraModuleNames
        )
    {
        OutExtraModuleNames.AddRange( new string[] { "Invaders_EIP" } );
    }
 

}