using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.Combat
{
	public class Projectile : MonoBehaviour
	{
		public BulletObject bulletObject;
		[SerializeField]
		private float startSpeed;
		[SerializeField]
		private float Mass;
		[SerializeField]
		private AttackType ammoAttribute;
		[SerializeField]
		private LayerMask collisionLayers;
		[SerializeField]
		private bool allowBulletDrop;
		[SerializeField]
		private bool applyRemainderForceToCollision;
		[SerializeField]
		private string weaponName;
		public GameObject projectileMeshGameObject;
		[SerializeField]
		private int MaxParticleSpawns;
		[SerializeField]
		private UnityEvent onCreate;
		[SerializeField]
		private UnityEventCollision onCollision;
		[SerializeField]
		private UnityEvent onDestroy;
		[SerializeField]
		private bool showDebugLines;
	}
}
