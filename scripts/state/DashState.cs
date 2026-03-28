using Godot;
using System;

public partial class DashState : State
{
    private int frictionForce = 10000;
    private float direction = 5000;

    public DashState(Entity entity) : base(entity) { }

    public override void Enter()
    {
        _entity.SetIsDashed(true);

        int dashForce = _entity.GetDashForce();
        direction = _entity.GetDirection();

        _entity.Velocity = new Vector2(dashForce * direction, 0);
    }

    public override void Update(double delta)
    {

        //ПЕРЕДЕЛАТЬ

        if (direction >= 0)
        {
            if (_entity.Velocity.X <= 0)
            {
                _entity.Velocity = Vector2.Zero;

                _entity.SetIsDashed(false);
            }
        }

        if (direction <= 0)
        {
            if (_entity.Velocity.X >= 0)
            {
                _entity.Velocity = Vector2.Zero;

                _entity.SetIsDashed(false);
            }
        }

        _entity.Velocity -= new Vector2(frictionForce * direction * (float)delta, 0);
    }

    public override void Idle()
    {
        if (!_entity.IsDashed())
        {
            _entity.SetState(new IdleState(_entity));
        }
    }

    public override void IdleFalling()
    {
        if (!_entity.IsDashed())
        {
            _entity.SetState(new IdleState(_entity));
        }
    }

    public override void Move()
    {
        if (!_entity.IsDashed())
        {
            _entity.SetState(new IdleState(_entity));
        }
    }

    public override void Jump()
    {
        if (!_entity.IsDashed())
        {
            _entity.SetState(new IdleState(_entity));
        }
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
