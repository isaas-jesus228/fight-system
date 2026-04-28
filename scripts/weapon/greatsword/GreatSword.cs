using Godot;

namespace FightSystem.scripts.weapon.greatsword
{
    internal partial class GreatSword : Weapon
    {
        private static string _pathAnimate = "AttacksGroup/GreatSwordAttack";
        private static string _pathAttackShape = "AttacksGroup/GreatSwordShape";

        public GreatSword(Entity entity) : base(entity, _pathAnimate, _pathAttackShape)
        {
            _damage = 40;

            if (_shapeAttack == null)
            {
                GD.PrintErr("ShapeAttack NULL: " + _pathAttackShape);
            }
            else
            {
                GD.Print("Shape OK: " + _shapeAttack.Name);
            }
        }
    }
}