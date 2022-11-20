using UnityEngine;

namespace StressLevelZero.Combat
{
	public class ProjectileBalloon_Arena : MonoBehaviour
	{
		public LayerMask collisionLayers;
		public float effectiveRange;
		public float maxVelocity;
		public float constantBuoyantForce;
		public float maxImpactForce;
		public GameObject balloonArt;
		public Transform stringStartTransform;
		public Transform forceTargetTransform;
	}
}
