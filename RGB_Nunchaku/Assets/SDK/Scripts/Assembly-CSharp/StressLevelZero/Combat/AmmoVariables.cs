using System;

namespace StressLevelZero.Combat
{
	[Serializable]
	public struct AmmoVariables
	{
		public Cart cartridgeType;
		public AttackType AttackType;
		public float AttackDamage;
		public float ProjectileMass;
		public float ExitVelocity;
		public bool Tracer;
	}
}
