using FightSystem.scripts.weapon.sword;
using FightSystem.scripts.weapon.greatsword;
using Godot;

public partial class Player : Entity
{
    [Export]
    public int Health = 100;
    [Export]
    public int Speed = 20000;
	[Export]
    public int JumpForce = 1200;
	[Export]
	public int DashForce = 2500;

	private ActionBuffer _buffer = new ActionBuffer();

	public override void _Ready()
	{
        _health = Health;
        _speed = Speed;
		_jumpForce = JumpForce;
		_dashForce = DashForce;

		_state = new IdleState(this);
		_weapon = new GreatSword(this);

		AddChild(_buffer);
	}

	public override void _Process(double delta)
	{
		_buffer.Update();
	}


	public override void _PhysicsProcess(double delta)
	{
		Vector2 directionLook = GetGlobalMousePosition() - GlobalPosition;

		_direction = Input.GetAxis("left_move", "right_move");

		if (!IsDashed() && Input.IsActionJustPressed("dash"))
		{
			_state.Dash();

			//GD.Print("Дэшусь");
		}
		else if (!IsOnFloor())
		{
			_state.IdleFalling();

			//GD.Print("Падаю");
		}
		else if (IsOnFloor() && _buffer.Action == "jump")
		{
			_state.Jump();

			//GD.Print("Прыгаю");
		}
		else if (_direction != 0)
		{
			_state.Move();

			//GD.Print("Иду");
		}
		else
		{
			_state.Idle();

			//GD.Print("Стою");
		}

		if (Input.IsActionJustPressed("attack"))
		{
			_weapon.Attack();
		}

		GetNode<Node2D>("AttacksGroup").Rotation = directionLook.Angle();

		_state.Update(delta);
		MoveAndSlide();
	}
}
