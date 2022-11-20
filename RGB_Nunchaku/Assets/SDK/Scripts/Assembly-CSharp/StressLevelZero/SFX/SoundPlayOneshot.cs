using UnityEngine;

namespace StressLevelZero.SFX
{
	public class SoundPlayOneshot : MonoBehaviour
	{
		public AudioClip[] waveFiles;
		public float volMin;
		public float volMax;
		public float pitchMin;
		public float pitchMax;
		public bool playOnAwake;
	}
}
