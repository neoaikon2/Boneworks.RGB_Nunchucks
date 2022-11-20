using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.SFX
{
	public class ImpactSFX : MonoBehaviour
	{
		public AudioMixerGroup outputMixer;
		public GameObject sourceObj;
		public AudioClip[] impactSoft;
		public AudioClip[] impactHard;
		public AudioClip[] destruction;
		public AudioClip[] jointBreak;
		public Collider[] altImpactColliders;
		public AudioClip[] altImpact;
		public float pitchMod;
		public bool bluntAttack;
		public float bluntDamageMult;
		public float minVelocity;
		public float velocityClipSplit;
		public float jointBreakVolume;
	}
}
