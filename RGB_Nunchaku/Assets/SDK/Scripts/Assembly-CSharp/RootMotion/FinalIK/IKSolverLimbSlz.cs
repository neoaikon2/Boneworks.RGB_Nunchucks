using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverLimbSlz : IKSolverTrigonometricSlz
	{
		public enum BendModifier
		{
			Animation = 0,
			Target = 1,
			Parent = 2,
			Arm = 3,
			Goal = 4,
			AnimTarHybrid = 5,
		}

		public AvatarIKGoal goal;
		public BendModifier bendModifier;
		public float maintainRotationWeight;
		public float bendModifierWeight;
		public Transform bendGoal;
	}
}
