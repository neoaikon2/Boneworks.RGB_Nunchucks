using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.SFX
{
	public class GenericTurretSFX : MonoBehaviour
	{
		public AudioMixerGroup outputMixer;
		public AudioMixerGroup loopOutputMixer;
		public AudioClip[] idleClips;
		public AudioClip[] alertClips;
		public AudioClip[] patrolClips;
		public AudioClip[] unPackClips;
		public AudioClip[] packClips;
		public AudioClip[] speakClips;
		public AudioClip[] deathClips;
		public AudioClip[] impactClips;
		public AudioClip[] alarmClips;
		public AudioClip[] jumpClips;
	}
}
