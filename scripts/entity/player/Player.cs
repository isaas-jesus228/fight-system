using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class Player : Entity
{
	[Export]
	private int Speed = 20000;
	[Export]
	private int JumpForce = 1200;

	public override void _Ready()
	{
		_speed = Speed;
		_jumpForce = JumpForce;

		_state = new IdleState(this);
	}

	public override void _Process(double delta)
	{
		_direction = Input.GetAxis("left_move", "right_move");

		if (!IsOnFloor())
		{
			_state.IdleFalling();
		}
		else if (IsOnFloor() && Input.IsActionPressed("jump"))
		{
			_state.Jump();
		}
		else if (_direction != 0)
		{
			_state.Move();
		}
		else
		{
			_state.Idle();
		}

		_state.Update(delta);
		MoveAndSlide();
	}
}
