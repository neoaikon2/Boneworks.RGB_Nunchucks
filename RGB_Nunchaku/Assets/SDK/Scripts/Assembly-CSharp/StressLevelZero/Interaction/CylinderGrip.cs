using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class CylinderGrip : TargetGrip
	{
		public float dynamicFriction;
		public float staticFriction;
		public float limit;
		public bool rotationalSweetSpot;
		public AnimationCurve SweetGrabCurve;
		public float rotationalFrictionMult;
		public float aspectRatio;
		public bool varyPositionalFriction;
		public AnimationCurve PositionFrictionCurve;
		public bool variableRadius;
		public AnimationCurve RadiusCurve;
		public bool fauxMovingGrip;
		public float fauxGripVelocity;
		public float multiHandSeperation;
	}
}
