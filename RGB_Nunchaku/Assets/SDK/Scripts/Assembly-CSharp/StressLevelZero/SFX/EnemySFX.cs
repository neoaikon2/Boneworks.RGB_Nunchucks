using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.SFX
{
	public class EnemySFX : MonoBehaviour
	{
		public AudioMixerGroup mixerGroup;
		public AudioClip[] agro;
		public AudioClip[] unAgro;
		public AudioClip[] painSmall;
		public AudioClip[] painBig;
		public AudioClip[] death;
		public AudioClip[] jumpCharge;
		public AudioClip[] jump;
		public AudioClip[] smallEffort;
		public AudioClip[] mediumEffort;
		public AudioClip[] largeEffort;
		public AudioClip[] attack1;
		public AudioClip dotLoop1;
		public AudioClip agroMovementLoop;
		public AudioClip meanderMovementLoop;
		public AudioClip roamMovementLoop;
	}
}
