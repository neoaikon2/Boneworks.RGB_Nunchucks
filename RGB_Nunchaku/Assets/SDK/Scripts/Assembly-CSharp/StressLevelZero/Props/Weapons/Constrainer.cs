using UnityEngine;
using StressLevelZero.Interaction;
using StressLevelZero.SFX;

namespace StressLevelZero.Props.Weapons
{
	public class Constrainer : MonoBehaviour
	{
		public enum ConstraintMode
		{
			Tether = 0,
			Weld = 1,
			BallSocket = 2,
			Elastic = 3,
			EntangleRotation = 4,
			EntagleVelocity = 5,
			Remove = 6,
		}

		public ConstraintMode mode;
		public Grip triggerGrip;
		public Transform firePoint;
		public float maxRange;
		public LayerMask layerMask;
		public GravGunSFX sfx;
		public GameObject laser;
		[SerializeField]
		private Material LineMaterial;
	}
}
