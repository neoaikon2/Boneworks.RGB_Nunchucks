using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.SFX
{
	public class GunSFX : MonoBehaviour
	{
		public AudioMixerGroup gunshotOutputMixer;
		public AudioMixerGroup interactionOutputMixer;
		public AudioClip[] fire;
		public AudioClip[] fireSlow;
		public AudioClip[] grab;
		public AudioClip[] secondGrip;
		public AudioClip[] slidePull;
		public AudioClip[] slideRelease;
		public AudioClip[] magazineInsert;
		public AudioClip[] magazineDrop;
		public AudioClip[] dryFire;
		public AudioClip[] dryFireSlow;
		public AudioClip[] slideLockFire;
		public AudioClip[] slideLockFireSlow;
	}
}
