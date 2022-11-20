using UnityEngine;
using UnityEngine.Audio;

namespace Boneworks
{
	public class Door_Opener : MonoBehaviour
	{
		public AudioMixerGroup outputMixer;
		public GameObject sourceObj;
		public AudioClip[] impactSoft;
		public AudioClip[] impactHard;
		public bool oneShot;
		public float minVelocity;
		public float velocityClipSplit;
		public int knocks;
		public bool permalocked;
	}
}
