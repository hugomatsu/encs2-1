﻿using Unity.Entities;
using Unity.Mathematics;


[GenerateAuthoringComponent]
public struct C_ReachTarget : IComponentData
{
    public float3 TargetPosition;
    public float ReachDistance;
    public float ActionDistance;
}


public enum E_TargetType
{
    MechaPart,
    Mouse
}

public enum E_MechaPart
{
    Legs = 0,
    Body,
    Head,
   
}