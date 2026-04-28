using Godot;
using System;

public partial class ActionBuffer : Godot.Timer
{
	public string Action = "";

	public override void _Ready()
	{
		Timeout += OnTimerTimeout;
	}


	public void Update()
	{
		if (Input.IsActionJustPressed("jump") && Action == "")
		{
			Action = "jump";

			Start(0.1);
		}
	}

	private void OnTimerTimeout()
	{
		Action = "";
	}

}
