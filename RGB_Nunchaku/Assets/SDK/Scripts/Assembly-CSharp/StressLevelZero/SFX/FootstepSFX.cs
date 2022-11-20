using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.SFX
{
	public class FootstepSFX : MonoBehaviour
	{
		public AudioMixerGroup outputMixer;
		public AudioClip[] walkConcrete;
		public AudioClip[] runConcrete;
		public AudioClip[] crouchConcrete;
		public AudioClip[] walkMetal;
	}
}
