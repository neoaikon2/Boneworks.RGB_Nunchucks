using UnityEngine;
using StressLevelZero.Rig;

public class Haptor : MonoBehaviour
{
	public bool hapticsAllowed;
	public BaseController device_Controller;
	public Haptor otherHaptor;
	public float mod_globalPer;
	public float low_thr_freq;
	public float hap_duration;
	public float hap_frequency;
	public float hap_amplitude;
	public float hap_calc_t;
	public float hap_subtle_t;
	public float hap_subtle_frequency;
	public float hap_subtle_amplitude;
	public float hap_click_down_t;
	public float hap_click_down_frequency;
	public float hap_click_down_amplitude;
	public float hap_click_up_t;
	public float hap_click_up_frequency;
	public float hap_click_up_amplitude;
	public float hap_tap_duration;
	public float hap_tap_frequency;
	public float hap_tap_amplitude;
	public float hap_knock_duration;
	public float hap_knock_frequency;
	public float hap_knock_amplitude;
	public float hap_hit_mod;
	public float hap_hit_frequency;
	public int sin_gateCount;
	public float hap_softSin_length;
	public float hap_softSin_freq;
	public float hap_max_softSin_amp;
	public float hap_min_softSin_amp;
	public float hap_hardSin_length;
	public float hap_hardSin_freq;
	public float hap_max_hardSin_amp;
	public float hap_min_hardSin_amp;
}
