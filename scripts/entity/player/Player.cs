using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class Player : Entity
{
	public override void _Ready()
	{
		_state = new Idle();
		_state.Enter();
	}

	public override void _Process(double delta)
	{
	}
}
