using UnityEngine;
using StressLevelZero.VRMK;

namespace HandRigDevelopment2
{
	public class PhysicalFollow : MonoBehaviour
	{
		public Rigidbody rb;
		public bool isRigidbodyOverride;
		public float maxForce;
		public float dampening;
		public float newtonDamp;
		public float maxTorque;
		public float angDampening;
		public bool followVelocity;
		public float forceMultiplier;
		public float xPosForce;
		public float xNegForce;
		public float yPosForce;
		public float yNegForce;
		public float zPosForce;
		public float zNegForce;
		public AnimationCurve ArmXyCurve;
		public AnimationCurve ArmZCurve;
		public AnimationCurve ArmZNegCurve;
		public AnimationCurve FvCurve;
		public PhysBody physBody;
		public bool isUsingRealisticDrag;
		public float dragCoefficient;
		public float referenceArea;
	}
}
