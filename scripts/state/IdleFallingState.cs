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

        _entity.Velocity += new Vector2(direction * speed * (float)delta, 0);


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
        return;
    }

    public override void Jump()
    {
        return;
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
