using Godot;
using System;
using System.Collections.Generic;

public abstract partial class Entity : CharacterBody2D
{
    protected State _state;
    protected string _weapon;
    protected List<string> _effects;

    protected int _speed;
    protected int _jumpForce;
    protected int _dashForce;
    protected float _direction;
    protected int _health;

    protected bool _isDashed;

    public int GetSpeed() { return _speed; }
    public float GetDirection() { return _direction; }
    public int GetJumpForce() { return _jumpForce; }
    public int GetDashForce() { return _dashForce; }

    public bool IsDashed() { return _isDashed; }

    public void SetState(State state) { _state = state; }
    public void SetIsDashed(bool isDashed) { _isDashed = isDashed; }

    public void DealDamage(int damage)
    {
        _health -= damage;

        if (_health == 0) { QueueFree(); }
    }
}
