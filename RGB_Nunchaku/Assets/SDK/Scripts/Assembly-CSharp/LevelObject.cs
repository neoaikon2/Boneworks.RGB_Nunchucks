using UnityEngine;

public class LevelObject : MonoBehaviour
{
	public string string_LevelToload;
	public string string_LongName;
	public Transform hypercube;
	public Vector3 scl_hypercube_IN;
	public Vector3 scl_hypercube_OUT;
	public float scl_length;
	public float scl_speed;
	public float scl_t;
	public ParticleSystem fx_particleHighlight;
	public AudioSource src_Audio;
	public AudioClip clip_Select;
	public AudioClip clip_DeSelect;
}
