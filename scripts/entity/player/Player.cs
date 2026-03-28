using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class Player : Entity
{
	[Export]
	private int Speed = 20000;
	[Export]
	private int JumpForce = 1200;
	[Export]
	private int DashForce = 2500;

	public override void _Ready()
	{
		_speed = Speed;
		_jumpForce = JumpForce;
		_dashForce = DashForce;

		_state = new IdleState(this);
	}

	public override void _PhysicsProcess(double delta)
	{
		_direction = Input.GetAxis("left_move", "right_move");

		if (!IsDashed() && Input.IsActionJustPressed("dash"))
		{
			_state.Dash();

			GD.Print("Дэшусь");
		}
		else if (!IsOnFloor())
		{
			_state.IdleFalling();

			GD.Print("Падаю");
		}
		else if (IsOnFloor() && Input.IsActionJustPressed("jump"))
		{
			_state.Jump();

			GD.Print("Прыгаю");
		}
		else if (_direction != 0)
		{
			_state.Move();

			GD.Print("Иду");
		}
		else
		{
			_state.Idle();

			GD.Print("Стою");
		}

		_state.Update(delta);
		MoveAndSlide();
	}
}
