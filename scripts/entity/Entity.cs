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
    protected float _direction;

    public int GetSpeed() { return _speed; }
    public float GetDirection() { return _direction; }
    public int GetJumpForce() { return _jumpForce; }

    public void SetState(State state) { _state = state; }
}
