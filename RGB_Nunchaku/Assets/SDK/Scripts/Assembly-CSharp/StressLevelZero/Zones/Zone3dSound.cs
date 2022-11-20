using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.Zones
{
	public class Zone3dSound : ZoneItem
	{
		public Transform targetTran;
		public AudioClip clip;
		public AudioMixerGroup mixerGroup;
		public float primaryVolume;
		public float secondaryVolume;
		public float pitch;
		public float fadeSpeed;
		public float sourceRadius;
		public bool loop;
	}
}
