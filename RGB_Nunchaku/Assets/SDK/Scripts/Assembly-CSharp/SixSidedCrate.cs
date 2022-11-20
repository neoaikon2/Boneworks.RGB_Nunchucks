using UnityEngine;

public class SixSidedCrate : MonoBehaviour
{
	public bool damageFromImpact;
	public float mod_Impact;
	public float mod_Impact_Player;
	public float thr_Impact;
	public bool damageFromAttack;
	public float mod_Attack;
	public GameObject[] sides;
	public GameObject[] spawnSides;
	public float max_sideHealth;
	public int req_hit;
	public bool canOverDamage;
	public bool nonSixSided;
	public Transform fx_Audio;
}
