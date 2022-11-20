using UnityEngine;

public class Stat_Health : MonoBehaviour
{
	public float reg_mod_t;
	public bool emr_Health;
	public bool dying;
	public bool MaxedHealth;
	public bool LockHealth;
	public bool alw_reg_Health;
	public int lvl_Health;
	public int lvl_reg_Health;
	public int game_max_lvl_Health;
	public int game_max_lvl_reg_Health;
	public float def_Health;
	public float cur_Health;
	public float tar_Health;
	public float max_Health;
	public float reg_Health_amt;
	public float mod_Health;
	public float game_max_Health;
	public float thr_dmg_dif_Health;
	public float thr_emr_Health;
	public float dmg_mod_Health;
	public float mod_ext_Health;
	public Stat_TimeUntilDeath ctrl_TUD;
	public float tmp_Health;
}
