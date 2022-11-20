using UnityEngine;

namespace StressLevelZero.VRMK
{
	public class PhysHand : MonoBehaviour
	{
		public enum HandPhysState
		{
			Empty = 0,
			RbOneHand = 1,
			RbTwoHand = 2,
			StaticOneHand = 3,
			StaticTwoHand = 4,
		}

		public Rigidbody rb;
		public ConfigurableJoint bodyJ;
		public PhysBody physBody;
		public PhysHand otherHand;
		public float dampening;
		public float newtonDamp;
		public float additionalMass;
		public float forceMultiplier;
		public float xPosForce;
		public float xNegForce;
		public float yPosForce;
		public float yNegForce;
		public float zPosForce;
		public float zNegForce;
		public float maxTorque;
		public float angDampening;
		public float gripMult;
		public AnimationCurve TorqueMultiplier;
		public Collider forearmCol;
		public Transform t1Vert;
		public Transform shoulder;
		public Transform wrist;
		public Vector3 currentCollision;
		public Vector3 appliedForce;
		public Vector3 appliedTorque;
		public float handSupported;
		public PhysicMaterial lowFriction;
		public Collider[] handColliders;
		public Vector3 rbOffset;
		public bool drawMaxForceDebug;
		public bool drawAccuracyDebug;
		public bool forceViaJoint;
		public HandPhysState handPhysState;
	}
}
