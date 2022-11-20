using UnityEngine;

public class Stat_TimeUntilDeath : MonoBehaviour
{
	public int lvl_TUD;
	public bool currently_Dying;
	public float cur_TUD;
	public float max_TUD;
	public float def_TUD;
	public bool cur_SavingThrow_TUD;
	public bool cur_SlowTime_TUD;
	public bool cur_Blind_TUD;
	public bool cur_Flashing_TUD;
	public bool cur_LPF_TUD;
	public bool can_SavingThrow_TUD;
	public bool can_SlowTime_TUD;
	public float slowTime_int_Dying;
	public bool can_Blind_TUD;
	public bool can_Flashing_TUD;
	public bool can_LPF_TUD;
	public Control_GlobalTime ctrl_GlobalTime;
	public Control_GlobalAudio ctrl_GlobalAudio;
	public Control_CameraEffects ctrl_Camera;
	public Control_Game ctrl_Game;
}
