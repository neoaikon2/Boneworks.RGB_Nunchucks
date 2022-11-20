using System;
using StressLevelZero.Combat;
using UnityEngine;

namespace StressLevelZero.Pool
{
	[Serializable]
	public class ImpactParticleProperties
	{
		public ImpactPropertiesVariables.Material material;
		public GameObject NormalImpactPrefab;
		public GameObject BacksideImpactPrefab;
		public PoolMode mode;
		public float spawnFrequency;
		public float spawnDistance;
		public float spawnStackDistance;
		public int spawnStackCount;
		public int initialPoolAmount;
	}
}
