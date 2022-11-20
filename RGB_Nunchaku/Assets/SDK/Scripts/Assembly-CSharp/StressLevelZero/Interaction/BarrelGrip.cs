using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.Interaction
{
	public class BarrelGrip : TargetGrip
	{
		public enum Caps
		{
			PositiveCap = 1,
			NegativeCap = 2,
		}

		[SerializeField]
		private CapsuleCollider _capsuleCollider;
		public float ringThickness;
		public HandPose ringHandPose;
		public float ringMinBreakForce;
		public float ringMaxBreakForce;
		public HandPose sideHandPose;
		public float sideMinBreakForce;
		public float sideMaxBreakForce;
		public HandPose edgeHandPose;
		public float edgeMinBreakForce;
		public float edgeMaxBreakForce;
		public HandPose capHandPose;
		public float capMinBreakForce;
		public float capMaxBreakForce;
		public bool isCurveOverride;
		public AnimationCurve heightAndRadiusCurve;
		[SerializeField]
		private Caps enabledCaps;
	}
}
