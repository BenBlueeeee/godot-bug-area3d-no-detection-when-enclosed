using Godot;
using System;

public partial class BrokenArea3D : Area3D
{
	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		GD.Print(GetOverlappingBodies());
	}
}
