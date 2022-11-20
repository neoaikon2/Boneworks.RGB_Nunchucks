using UnityEngine;
using StressLevelZero.Combat;

public class Enemy_Health : MonoBehaviour
{
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
	public bool invulnerable;
	public float max_Health;
	[SerializeField]
	public float cur_Health;
	public int req_hit_count;
	public int hits;
	public bool bloodied;
	public float per_Bloodied;
	public float imm_death_t;
	public GameObject fx_bloodied;
	public float amt_Regen;
	public float wait_Regen_t;
	public float freq_Regen_t;
	public bool regenerating;
	public GameObject fx_regen;
	public float thr_React;
	public bool DestroyOnDeath;
	public bool spawnHeroProps;
	public bool alive;
	public bool Pooled;
	public Transform[] spawn_points;
	public bool autoRespawn;
	public GameObject fx_death;
	public GameObject[] prop_Hero;
}
