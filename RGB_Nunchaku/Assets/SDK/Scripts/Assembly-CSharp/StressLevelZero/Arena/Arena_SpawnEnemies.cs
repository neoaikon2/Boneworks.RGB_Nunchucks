using UnityEngine;
using StressLevelZero.Data;
using PuppetMasta;
using StressLevelZero.AI;

namespace StressLevelZero.Arena
{
	public class Arena_SpawnEnemies : MonoBehaviour
	{
		public bool visDebug;
		public Transform[] northDoorSpawns;
		public Transform[] eastDoorSpawns;
		public Transform[] westDoorSpawns;
		public Arena_Volume[] friendlySpawnVolumes;
		public Transform kingSpawn;
		[SerializeField]
		private SpawnableObject crabObject;
		[SerializeField]
		private SpawnableObject brettObject;
		[SerializeField]
		private SpawnableObject zombieObject;
		[SerializeField]
		private SpawnableObject nullBodyObject;
		[SerializeField]
		private SpawnableObject omniObject;
		[SerializeField]
		private SpawnableObject crabletPlusObject;
		[SerializeField]
		private SpawnableObject shortHairedBrettSpawnable;
		[SerializeField]
		private SpawnableObject crownSpawnable;
		[SerializeField]
		private SpawnableObject plantSpawnable;
		public BaseEnemyConfig zombieConfig;
		public BaseEnemyConfig zombieThrowerConfig;
		public BaseEnemyConfig friendlyFordConfig;
		public bool clonedPlayer;
		public bool isEmitting;
		public bool isFinishedSpawning;
		public int activeEnemyCount;
		public float currentWaitTime;
		[SerializeField]
		private int currEnemy;
		public Arena_Launcher hoiPoiLauncher;
		public TriggerRefProxy playerProxy;
		public GameObject spawnedBall;
		[SerializeField]
		private SpawnableObject basketballSpawnable;
		public TriggerRefProxy goalTriggerRef;
		public Arena_Volume killBallVol;
	}
}
