using UnityEngine;

namespace StressLevelZero.Props.Weapons
{
	public class GravityManipulatorJob : MonoBehaviour
	{
		public float targetMinDistance;
		public bool isAutoCollect;
		public float maxMoveSpeed;
		public float minimumGrabRatio;
		public LayerMask pullableLayerMask;
		public float fieldOffset;
		public float keepFieldRadius;
		public float minKeepFieldForce;
		public float maxKeepFieldForce;
		public float keepFieldDampening;
		public float deadZoneRadius;
		public float deadZoneForce;
		public float deadZoneDampening;
		public bool startActive;
		public int maxGravityObjects;
		public float grabFieldAngle;
		public float grabFieldOffset;
		public float distanceOffset;
		public Quaternion rotationOffset;
		public int maxLines;
		public Gradient color;
		public Material lineMaterial;
		public Material pointMaterial;
		public Rigidbody relativeRigidbody;
		public Transform firePoint;
		public Transform spaceTimeDistortion;
		public Rigidbody lockedParentRigidbody;
	}
}
