using StressLevelZero.Zones;
using UnityEngine;

namespace StressLevelZero.SFX
{
	public class ZoneSound : ZoneItem
	{
		public bool onlyPlayOnce;
		public bool isMusic;
		public AudioClip clipToCue;
		public float volume;
		public bool loop;
		public float fadeInTime;
		public float fadeOutTime;
		public bool playOnEnter;
		public bool stopOnEnter;
		public bool stopOnExit;
	}
}
