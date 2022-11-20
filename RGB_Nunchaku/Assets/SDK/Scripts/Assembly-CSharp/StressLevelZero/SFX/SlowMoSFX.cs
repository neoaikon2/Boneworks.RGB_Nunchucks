using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.SFX
{
	public class SlowMoSFX : MonoBehaviour
	{
		public AudioClip decelTime;
		public AudioClip accelTime;
		public AudioMixerGroup outputMixer;
	}
}
