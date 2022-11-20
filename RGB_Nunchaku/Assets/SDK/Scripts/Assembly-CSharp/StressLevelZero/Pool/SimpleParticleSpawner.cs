using UnityEngine;

namespace StressLevelZero.Pool
{
	public class SimpleParticleSpawner : MonoBehaviour
	{
		[SerializeField]
		private PoolSpawner.BlasterType SpawnedBlaster;
		[SerializeField]
		private bool PlayOnEnable;
	}
}
