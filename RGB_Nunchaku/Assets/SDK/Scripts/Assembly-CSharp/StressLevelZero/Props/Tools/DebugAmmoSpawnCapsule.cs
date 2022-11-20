using UnityEngine;
using StressLevelZero.Interaction;
using StressLevelZero.Arena;

namespace StressLevelZero.Props.Tools
{
	public class DebugAmmoSpawnCapsule : MonoBehaviour
	{
		public Grip triggerGrip;
		public InteractableHost host;
		public float maxDistFromCenter;
		public Arena_SpawnEnemies arenaSpawner;
		public SphereCollider expandCollider;
		public float finalExpandRadius;
	}
}
