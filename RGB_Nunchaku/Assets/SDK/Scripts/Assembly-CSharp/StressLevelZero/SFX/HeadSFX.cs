using UnityEngine;
using System;
using UnityEngine.Audio;
using StressLevelZero.AI;

namespace StressLevelZero.SFX
{
	public class HeadSFX : MonoBehaviour
	{
		[Serializable]
		public class AmbAndMusic
		{
			public AudioSource ambMus;
			public AudioClip clip;
			public bool isFading;
			public float fadeTarget;
			public float fadePerSec;
		}

		public AudioClip[] jumpEffort;
		public AudioClip[] smallDamage;
		public AudioClip[] bigDamage;
		public AudioClip[] dying;
		public AudioClip[] dead;
		public AudioClip[] recovery;
		public AmbAndMusic[] ambAndMusics;
		public AudioMixerGroup AmbientMixerGroup;
		public AudioMixerGroup MusicMixerGroup;
		public Rigidbody rb_parent;
		public LayerMask meleeAttackMask;
		public AudioClip[] headbuttClips;
		public AudioClip[] headbuttClipsSlowmo;
		public TriggerRefProxy proxy;
		public float minSpeed;
		public float maxSpeed;
		public AudioMixerGroup outputMixer;
		public AudioClip windBuffetClip;
		public AudioClip windBuffetSlowMo;
		public AudioSource mouthSrc;
	}
}
