using UnityEngine;
using StressLevelZero.Combat;
using StressLevelZero.Pool;
using UnityEngine.Events;

namespace StressLevelZero.Props
{
	public class Prop_Health : MonoBehaviour
	{
		public bool RESETABLE;
		public bool Pooled;
		public bool damageFromImpact;
		public float mod_Impact;
		public float thr_Impact;
		public bool useMask;
		public LayerMask msk_Impact;
		public float mod_Minimal;
		public bool damageFromAttack;
		public float mod_Attack;
		public bool useType;
		public AttackType mod_Type;
		public float mod_TypeDamage;
		public Collider[] col_crit;
		public float mod_crit;
		public GameObject fx_crit;
		public float max_Health;
		[SerializeField]
		private float cur_Health;
		public int req_hit_count;
		public int hits;
		public bool bloodied;
		public float per_Bloodied;
		public bool useMaterialChange;
		public float amt_Regen;
		public float wait_Regen_t;
		public bool regenerating;
		public GameObject fx_regen;
		public float thr_React;
		public int max_Bits;
		public int min_Bits;
		public bool spawnHeroProps;
		public float t_Despawn;
		public float t_Occlusion;
		public bool useOcclusion;
		public bool use_Explosion;
		public bool drop_Bloodied;
		public float bloodied_t;
		public float force_Explosion;
		public float force_Rotation;
		public GameObject fx_Explosion;
		public GameObject fx_Bloodied;
		public GameObject fx_Death;
		[SerializeField]
		private PoolSpawner.BlasterType BreakEffect;
		[SerializeField]
		private float BreakEffectSize;
		public bool rnd_Item;
		public float rnd_Chance;
		public GameObject[] obj_Reward;
		public GameObject fx_Reward;
		public GameObject prop_Whole;
		public GameObject[] prop_Damaged;
		public Material[] mat_Damaged;
		public GameObject[] prop_Bits;
		public GameObject[] prop_Hero;
		public AudioClip[] clip_bloodied;
		[SerializeField]
		private UnityEvent BreakEvent;
	}
}
