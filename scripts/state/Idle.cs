using Godot;
using System;

public partial class Idle : State
{
	public override void Enter()
	{
		Console.WriteLine("Стою");
	}

	public override void Update()
	{
		throw new NotImplementedException();
	}

	public override void Exit()
	{
		throw new NotImplementedException();
	}


}
