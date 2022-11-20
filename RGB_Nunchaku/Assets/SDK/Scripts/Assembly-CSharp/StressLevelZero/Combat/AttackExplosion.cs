using UnityEngine;

namespace StressLevelZero.Combat
{
	public class AttackExplosion : MonoBehaviour
	{
		[SerializeField]
		private float ExplosionRadius;
		[SerializeField]
		private float ExplosionForce;
		[SerializeField]
		private LayerMask Layers;
	}
}
