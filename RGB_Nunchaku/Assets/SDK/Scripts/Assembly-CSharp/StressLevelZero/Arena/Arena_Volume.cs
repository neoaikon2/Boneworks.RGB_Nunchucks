using UnityEngine;
using System.Collections.Generic;
using StressLevelZero.AI;
using StressLevelZero.Combat;

namespace StressLevelZero.Arena
{
	public class Arena_Volume : MonoBehaviour
	{
		public enum VolumeType
		{
			DAMAGE = 0,
			CLONER = 1,
			EVOLVE = 2,
			INSTANT_DEATH = 3,
			CRABSKETBALL = 4,
			KILL_BALL = 5,
			SPAWN = 6,
			LOOT_SPAWN = 7,
		}

		public VolumeType volumeType;
		public Control_GlobalTime globalTimeControl;
		public List<TriggerRefProxy> triggerVolumeProxyList;
		public List<Arena_EnemyReference> enemyRefList;
		public bool isPlayerInTrig;
		[SerializeField]
		private Collider _collider;
		public float tickFrequency;
		public float damage;
		public bool damageOnEnter;
		public bool oneTimeDamage;
		public AttackType damageType;
		public int cloneAmount;
		public Transform cloneSpawnPoint;
		public bool isEnemyGoal;
		public GameObject spawnedBall;
	}
}
