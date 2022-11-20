using UnityEngine;

namespace StressLevelZero.Rig
{
	public class WASDCamera : MonoBehaviour
	{
		public Camera Camera;
		public Transform c1Vert;
		public Transform t1Vert;
		public Transform sacrum;
		public Transform fpsFollowPoint;
		public Transform tpsFollowPoint;
		public Vector2 FollowTransformFraming;
		public float FollowingSharpness;
		public float centerOfMassMult;
		public float DefaultDistance;
		public float MinDistance;
		public float MaxDistance;
		public float DistanceMovementSpeed;
		public float DistanceMovementSharpness;
		public float MouseSensitivity;
		public bool InvertX;
		public bool InvertY;
		public float DefaultVerticalAngle;
		public float MinVerticalAngle;
		public float MaxVerticalAngle;
		public float RotationSpeed;
		public float RotationSharpness;
		public float crouchDefault;
		public float crouchMin;
		public float crouchMax;
		public float crouchMovementSpeed;
		public float crouchMovementSharpness;
		public float ObstructionCheckRadius;
		public LayerMask ObstructionLayers;
		public float ObstructionSharpness;
	}
}
