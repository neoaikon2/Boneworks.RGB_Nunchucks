using UnityEngine;

namespace StressLevelZero.Pool
{
	public class GenericPoolManager<T> : MonoBehaviour
	{
		public GameObject Prefab;
		public int pooledAmount;
		public int warmupAmount;
		public PoolMode mode;
		public float spawnFrequency;
		public float spawnDistance;
		public float spawnStackDistance;
		public int spawnStackCount;
		public bool ignoreDisableDelay;
	}
}
