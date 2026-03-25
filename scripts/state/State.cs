using Godot;
using System;

public abstract partial class State : Node
{
	protected Entity _entity;

	public State(Entity entity)
	{
		_entity = entity;

		Enter();
	}

	public abstract void Enter();

	public abstract void Update(double delta);

	public abstract void Idle();

	public abstract void IdleFalling();

	public abstract void Jump();

	public abstract void Move();

	public abstract void Dash();

	public abstract void Block();
}
