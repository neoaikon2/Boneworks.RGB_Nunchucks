using System;
using UnityEngine.Audio;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourSfx : SubBehaviourBase
	{
		public AudioMixerGroup mixerGroup;
		public AudioMixerGroup impactMixerGroup;
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
		public AudioClip[] attackLand1;
		public AudioClip[] attack2;
		public AudioClip[] impactHead;
		public AudioClip[] impactSpine;
		public AudioClip[] impactLimb;
		public AudioClip dotLoop1;
		public AudioClip agroMovementLoop;
		public AudioClip movementLoop;
		[SerializeField]
		private float pitchMultiplier;
		public AudioSource impactSource;
	}
}
