using UnityEngine;
using UnityEngine.Audio;
using StressLevelZero.AI;
using StressLevelZero.Pool;

public class RigidbodyProjectile : MonoBehaviour
{
	[SerializeField]
	private Rigidbody _rb;
	public LayerMask attackLayerMask;
	public LayerMask blockLayerMask;
	public AudioClip[] throwClips;
	public AudioClip[] hitClips;
	public AudioMixerGroup mixerGroup;
	public TriggerRefProxy throwerProxy;
	[SerializeField]
	private PoolSpawner.BlasterType EffectType;
	[SerializeField]
	private float EffectScale;
}
