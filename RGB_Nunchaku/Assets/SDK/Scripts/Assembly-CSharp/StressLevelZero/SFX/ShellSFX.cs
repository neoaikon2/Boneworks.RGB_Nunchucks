using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.SFX
{
	public class ShellSFX : MonoBehaviour
	{
		public AudioMixerGroup outputMixer;
		public AudioClip[] impactBrass;
		public AudioClip[] impactPlastic;
		public AudioClip[] brassEject;
		public AudioClip[] brassEjectSlowMo;
		public AudioClip[] brassHeavyEject;
		public AudioClip[] brassHeavyEjectSlowMo;
		public float minVelocity;
		public bool spatialize;
	}
}
