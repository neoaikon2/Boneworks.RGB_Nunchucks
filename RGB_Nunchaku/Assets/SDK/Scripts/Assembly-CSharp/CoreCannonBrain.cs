using UnityEngine;
using UnityEngine.Audio;
using StressLevelZero.SFX;

public class CoreCannonBrain : MonoBehaviour
{
	[SerializeField]
	private Powerable_Joint _firingPin;
	[SerializeField]
	private AudioClip _fireClip;
	[SerializeField]
	private Rigidbody _spinnerRb;
	[SerializeField]
	private AudioMixerGroup _outputMixer;
	[SerializeField]
	private Transform _pressureGauge;
	[SerializeField]
	private AmbientSFX _steamSfx;
	[SerializeField]
	private Powerable_ParticleManager steamManager;
}
