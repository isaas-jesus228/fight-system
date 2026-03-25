using Godot;
using System;

public partial class IdleState : State
{
    public IdleState(Entity entity) : base(entity) { }

    public override void Enter()
    {
        _entity.Velocity = Vector2.Zero;
    }

    public override void Update(double delta)
    {
        return;
    }

    public override void Idle()
    {
        return;
    }

    public override void IdleFalling()
    {
        _entity.SetState(new IdleFallingState(_entity));
    }

    public override void Move()
    {
        _entity.SetState(new MoveState(_entity));
    }

    public override void Jump()
    {
        _entity.SetState(new JumpState(_entity));
    }

    public override void Dash()
    {
        return;
    }

    public override void Block()
    {
        return;
    }
}
