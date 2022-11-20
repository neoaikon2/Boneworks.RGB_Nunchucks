using UnityEngine;
using StressLevelZero.SFX;

namespace StressLevelZero.Props
{
	public class Balloon : MonoBehaviour
	{
		public enum BalloonColor
		{
			Red = 0,
			OrangeRed = 1,
			Orange = 2,
			YellowOrange = 3,
			Yellow = 4,
			GreenYellow = 5,
			Green = 6,
			BlueGreen = 7,
			Blue = 8,
			VioletBlue = 9,
			Violet = 10,
			RedViolet = 11,
			LightGray = 12,
			DarkGray = 13,
			Random = 14,
		}

		public bool scaleForceWithAttachedMass;
		public float maxVelocity;
		public float constantBuoyantForce;
		public float maxImpactForce;
		public ImpactSFX impactSFX;
		public Rigidbody myRigidbody;
		public ConfigurableJoint joint;
		public MeshRenderer artRenderer;
		public LineRenderer lineRenderer;
		public GameObject balloonArt;
		public Transform stringStartTransform;
		public Transform forceTargetTransform;
	}
}
