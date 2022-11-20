using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.SFX
{
	public class TriggeredAudio : MonoBehaviour
	{
		public AudioClip[] audioClips;
		public float volume;
		public float min_distance;
		public float pitch;
		public AudioMixerGroup mixingGroup;
	}
}
