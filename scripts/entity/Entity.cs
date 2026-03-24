using Godot;
using System;
using System.Collections.Generic;

#pragma warning disable CA1050 // Declare types in namespaces
public abstract partial class Entity : CharacterBody2D
{
    protected State _state;
    protected string _weapon;
    protected List<string> _effects;
}
