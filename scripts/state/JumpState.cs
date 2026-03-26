using Godot;
using System;

public partial class JumpState : State
{

    public JumpState(Entity entity) : base(entity) { }

    public override void Enter()
    {
        int jumpForce = _entity.GetJumpForce();

        _entity.Velocity += new Vector2(0, -jumpForce);
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
