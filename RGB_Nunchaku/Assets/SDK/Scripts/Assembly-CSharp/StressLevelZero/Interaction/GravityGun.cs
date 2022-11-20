using UnityEngine;
using StressLevelZero.VFX;
using StressLevelZero.Pool;

namespace StressLevelZero.Interaction
{
	public class GravityGun : TargetGrip
	{
		public LayerMask pullableLayerMask;
		public float maxDistance;
		public Transform firePoint;
		public Transform ejectPoint;
		public Transform centerOfMass;
		public Transform backPoint;
		public Transform targetPoint;
		public Transform glowerPoint;
		public QuadLine quadline;
		public GameObject blastVFXObject;
		public GameObject lockVFXObject;
		public BendLinePool linePool;
		public bool isAutomatic;
	}
}
