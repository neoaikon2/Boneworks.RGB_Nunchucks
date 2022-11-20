using UnityEngine;
using PuppetMasta;
using StressLevelZero.Pool;

namespace StressLevelZero.AI
{
	public class AIBrain : MonoBehaviour
	{
		public BehaviourBaseNav behaviour;
		public PuppetMaster puppetMaster;
		public EnemyTurret turret;
		public bool dontClearBaseConfig;
		public bool isDead;
		public Poolee poolee;
	}
}
