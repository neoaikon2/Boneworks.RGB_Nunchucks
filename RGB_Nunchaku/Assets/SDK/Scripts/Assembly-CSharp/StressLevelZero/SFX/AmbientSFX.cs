using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.SFX
{
	public class AmbientSFX : MonoBehaviour
	{
		public AudioMixerGroup mixerGroup;
		public AudioClip[] longPlay;
		public AudioClip powerUp;
		public AudioClip powerDown;
		public float volume;
		public float powerUpVolume;
		public float fadeSpeed;
		public float sourceRadius;
		public bool loop;
		public bool restartLoop;
		public bool playWhileInaudible;
		public bool blockTriggerExit;
		public float spatialBlend;
	}
}
