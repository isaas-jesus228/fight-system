using System.Data;
using Godot;

//TODO: Не все кадры наносить урон
public abstract class Weapon
{
    protected AnimatedSprite2D _animate;
    protected Entity _entity;
    protected Area2D _shapeAttack;

    protected int _damage;
    protected double _seconds;

    protected Weapon(Entity entity, string pathAnimate, string pathShapeAttack)
    {
        _entity = entity;
        _animate = _entity.GetNode<AnimatedSprite2D>(pathAnimate);
        _shapeAttack = _entity.GetNode<Area2D>(pathShapeAttack);

        _shapeAttack.BodyEntered += DealDamage;
        _animate.AnimationFinished += StopAttack;
    }

    public void Attack()
    {
        if (_animate.IsPlaying())
        {
            return;
        }

        _animate.Visible = true;
        _shapeAttack.Monitoring = true;

        _animate.Play();
    }

    public void StopAttack()
    {
        _animate.Visible = false;
        _shapeAttack.Monitoring = false;
    }

    public void DealDamage(Node2D target)
    {
        if (target is Player)
        {
            return;
        }
        else if (target is Entity entity)
        {
            entity.DealDamage(_damage);
        }
    }
}
