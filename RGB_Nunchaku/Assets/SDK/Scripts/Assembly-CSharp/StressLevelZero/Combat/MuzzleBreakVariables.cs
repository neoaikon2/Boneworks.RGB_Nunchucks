using System;

namespace StressLevelZero.Combat
{
	[Serializable]
	public struct MuzzleBreakVariables
	{
		public MuzzleBreakType muzzleBreakType;
		public float RecoilCompensation;
		public float MuzzleRiseCompensation;
	}
}
