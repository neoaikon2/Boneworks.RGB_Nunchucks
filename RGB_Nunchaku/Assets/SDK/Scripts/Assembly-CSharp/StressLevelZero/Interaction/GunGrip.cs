using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.Interaction
{
	public class GunGrip : TargetGrip
	{
		private enum GunProjectileType
		{
			Bullet = 0,
			SpawnPrefab = 1,
		}

		[SerializeField]
		private bool isInfiniteAmmo;
		[SerializeField]
		private float roundsPerMinute;
		public float muzzleVelocity;
		[SerializeField]
		private bool isAutomatic;
		[SerializeField]
		private Grip[] otherGrips;
		[SerializeField]
		private GunProjectileType gunProjectileType;
		[SerializeField]
		private GameObject PrefabToSpawn;
		[SerializeField]
		private Transform bulletSpawnTransform;
		[SerializeField]
		private Transform muzzleSpawnTransform;
		[SerializeField]
		private Transform casingSpawnTransform;
		[SerializeField]
		private Transform casingSpawnOrientationTransform;
		[SerializeField]
		private Transform shoulderPointTransform;
		public GameObject bulletArt;
		public GameObject bulletNext;
		public GameObject bulletExp;
		public Grip slideGrip;
		public CurveData slideCurve;
		public bool isHammerRaised;
	}
}
