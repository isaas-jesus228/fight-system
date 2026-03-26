using Godot;
using System;

public partial class MoveState : State
{

    public MoveState(Entity entity) : base(entity) { }

    public override void Enter()
    {
        return;
    }

    public override void Update(double delta)
    {
        float direction = _entity.GetDirection();
        float speed = _entity.GetSpeed();

        _entity.Velocity = new Vector2(direction * speed * (float)delta, 0);
    }

    public override void Idle()
    {
        _entity.SetState(new IdleState(_entity));
    }

    public override void IdleFalling()
    {
        _entity.SetState(new IdleFallingState(_entity));
    }

    public override void Move()
    {
        return;
    }

    public override void Jump()
    {
        _entity.SetState(new JumpState(_entity));
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
