using Godot;
using System;

public partial class IdleFallingState : State
{
    public IdleFallingState(Entity entity) : base(entity) { }

    public override void Enter()
    {
        return;
    }

    public override void Update(double delta)
    {
        float direction = _entity.GetDirection();
        float speed = _entity.GetSpeed();

        _entity.Velocity = new Vector2(direction * speed * (float)delta, _entity.Velocity.Y);

        Vector2 gravity = _entity.GetGravity();

        _entity.Velocity += gravity;
    }

    public override void Idle()
    {
        _entity.SetState(new IdleState(_entity));
    }

    public override void IdleFalling()
    {
        return;
    }

    public override void Move()
    {
        if (_entity.IsOnFloor())
        {
            _entity.SetState(new MoveState(_entity));
        }
    }

    public override void Jump()
    {
        if (_entity.IsOnFloor())
        {
            _entity.SetState(new JumpState(_entity));
        }
    }

    public override void Dash()
    {
        _entity.SetState(new DashState(_entity));
    }

    public override void Block()
    {
        return;
    }
}
