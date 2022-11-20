using UnityEngine;
using StressLevelZero.Combat;
using TMPro;

public class Player_Health : MonoBehaviour
{
	public enum HealthMode
	{
		Invincible = 0,
		Mortal = 1,
		InsantDeath = 2,
	}

	public HealthMode healthMode;
	public bool reloadLevelOnDeath;
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
	public float curr_Health;
	public int req_hit_count;
	public int hits;
	public bool bloodied;
	public float per_Bloodied;
	public float imm_death_t;
	public GameObject fx_bloodied;
	public GameObject[] prop_Hero;
	public float thr_React;
	public bool spawnHeroProps;
	public Transform[] spawn_points;
	public GameObject fx_death;
	public bool alive;
	public Control_GlobalTime globalTimeControl;
	[SerializeField]
	private bool visDebug;
	public bool isInstaDying;
	public bool displayHealthFX;
	public float wait_Regen_t;
	public float totalRegenDuration;
	public float deathTimeAmount;
	public float instaDeathTimeAmount;
	public float healthFromDeathSave;
	public float deathTimeReduction;
	public AnimationCurve shutEyeCurve;
	public Color darkRed;
	public Color brightRed;
	public MeshRenderer vigRend;
	public TMP_Text healthText;
}
