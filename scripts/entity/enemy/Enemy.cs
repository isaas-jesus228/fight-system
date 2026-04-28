using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace FightSystem.scripts.entity.enemy
{
	internal partial class Enemy : Entity
	{
		[Export]
		public int Health = 100;

		public Enemy()
		{
			_health = Health;
			_direction = 0;
			_speed = 0;

			_state = new IdleState(this);
		}

		public override void _PhysicsProcess(double delta)
		{
			if (!IsOnFloor())
			{
				_state.IdleFalling();
			}
			else
			{
				_state.Idle();
			}

			_state.Update(delta);
			MoveAndSlide();
		}
	}
}
