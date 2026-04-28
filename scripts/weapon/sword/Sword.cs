namespace FightSystem.scripts.weapon.sword
{
    internal partial class Sword : Weapon
    {
        private static string _pathAnimate = "AttacksGroup/SwordAttack";
        private static string _pathAttackShape = "AttacksGroup/SwordShape";

        public Sword(Entity entity) : base(entity, _pathAnimate, _pathAttackShape)
        {
            _damage = 20;
        }
    }
}