using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverTrigonometricSlz : IKSolver
	{
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone
		{
		}

		public Transform target;
		public float IKRotationWeight;
		public Quaternion IKRotation;
		public Vector3 bendNormal;
		public TrigonometricBone bone1;
		public TrigonometricBone bone2;
		public TrigonometricBone bone3;
	}
}
