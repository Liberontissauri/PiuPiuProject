using Godot;
using System;

public partial class CloseRangeMobHitbox : DamageSource
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.damage = 1;
	}
    public override void OnDamageDealt()
    {
    }
}
