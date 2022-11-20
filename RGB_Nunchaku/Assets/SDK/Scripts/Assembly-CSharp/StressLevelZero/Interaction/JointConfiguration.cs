using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class JointConfiguration
	{
		public Rigidbody connectedBody;
		public Vector3 axis;
		public Vector3 anchor;
		public Vector3 connectedAnchor;
		public bool autoConfigureConnectedAnchor;
		public float breakForce;
		public float breakTorque;
		public bool enableCollision;
		public bool enablePreprocessing;
		public Vector3 currentForce;
		public Vector3 currentTorque;
		public float massScale;
		public float connectedMassScale;
		public float projectionAngle;
		public float projectionDistance;
		public JointProjectionMode projectionMode;
		public RotationDriveMode rotationDriveMode;
		public Vector3 targetAngularVelocity;
		public Quaternion targetRotation;
		public Vector3 targetVelocity;
		public Vector3 targetPosition;
		public ConfigurableJointMotion angularZMotion;
		public ConfigurableJointMotion angularYMotion;
		public ConfigurableJointMotion angularXMotion;
		public ConfigurableJointMotion zMotion;
		public ConfigurableJointMotion yMotion;
		public ConfigurableJointMotion xMotion;
		public Vector3 secondaryAxis;
		public bool configuredInWorldSpace;
		public bool swapBodies;
		public ConfigurableJoint joint;
	}
}
