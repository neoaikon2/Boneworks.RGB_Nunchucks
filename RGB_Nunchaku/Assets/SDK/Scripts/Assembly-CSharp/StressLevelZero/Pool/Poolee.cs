using UnityEngine;
using StressLevelZero.Data;
using StressLevelZero.VFX;

namespace StressLevelZero.Pool
{
	public class Poolee : MonoBehaviour
	{
		public bool isClaimable;
		public SpawnableObject spawnObject;
		public SpawnableObject secondarySpawnObject;
		public ulong id;
		public DespawnMeshVFX despawn;
	}
}
