using Godot;
using System;

public abstract partial class State : Node
{
	protected CharacterBody2D _palyer;

	public abstract void Enter();

	public abstract void Update();

	public abstract void Exit();
}
