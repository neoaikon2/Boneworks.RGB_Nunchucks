using UnityEngine;
using UnityEngine.Audio;

public class Control_GlobalTime : MonoBehaviour
{
	public float max_intensity;
	public float lrp_calc_t;
	public float lrp_time;
	public AudioClip decelTime;
	public AudioClip accelTime;
	public AudioMixerGroup mixerGroup;
	public float cur_intensity;
	public float tar_intensity;
	public float tmp_intensity;
	public float def_intensity;
	public float tru_max_intensity;
	public float def_FixedDeltaTime;
	public int cur_timeScaleStep;
	public int max_timeScaleStep;
	public bool ControllingTime;
	public bool override_TimeControl;
}
