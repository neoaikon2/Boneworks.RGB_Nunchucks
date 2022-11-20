using UnityEngine;
using StressLevelZero;
using StressLevelZero.Data;
using StressLevelZero.Pool;
using StressLevelZero.Combat;
using StressLevelZero.SFX;

namespace StressLevelZero.Props
{
	public class ObjectDestructable : MonoBehaviour
	{
		public SaveItem saveItem;
		public LootTableData lootTable;
		public Transform spawnTarget;
		public bool damageFromImpact;
		public SpawnFragmentArray[] spawnFragments;
		[SerializeField]
		private PoolSpawner.BlasterType blasterType;
		[SerializeField]
		private float blasterScale;
		public float maxHealth;
		public int reqHitCount;
		public float perBloodied;
		public float explosiveForceOnDestruct;
		public bool damageFromAttack;
		public float attackMod;
		public AttackType attackType;
		public float modTypeDamage;
		public Collider[] colCrit;
		public float modCrit;
		public float modImpact;
		public float thrImpact;
		public float feetDamageMult;
		[SerializeField]
		private ImpactSFX _impactSfx;
	}
}
