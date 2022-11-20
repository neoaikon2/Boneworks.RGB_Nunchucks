using UnityEngine;

namespace StressLevelZero.VRMK
{
	public class PhysLimb : MonoBehaviour
	{
		public Rigidbody rb;
		public ConfigurableJoint j;
		public float xSpring;
		public float xDamp;
		public float sSpring;
		public float sDamp;
		public Collider upperCol;
		public Collider lowerCol;
		public Collider carpalCol;
		public Transform upper;
		public Transform lower;
		public Transform carpal;
		public PhysBody physBody;
	}
}
