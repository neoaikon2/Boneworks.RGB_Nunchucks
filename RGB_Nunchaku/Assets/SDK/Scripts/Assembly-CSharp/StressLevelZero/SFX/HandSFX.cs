using UnityEngine;
using UnityEngine.Audio;
using StressLevelZero.VRMK;

namespace StressLevelZero.SFX
{
	public class HandSFX : MonoBehaviour
	{
		public AudioClip[] grab;
		public AudioClip[] grabBig;
		public AudioClip[] drop;
		public AudioClip[] bodySlot;
		public AudioClip[] fallbackImpact;
		public AudioClip[] punch;
		public AudioClip[] slap;
		public AudioClip[] backhand;
		public AudioClip[] punchSlowMo;
		public AudioClip[] slapSlowMo;
		public AudioClip[] backhandSlowMo;
		public AudioClip whoosh;
		public AudioClip forceGrab;
		public AudioClip forceGrabLong;
		public LayerMask meleeAttackMask;
		public float minSpeed;
		public float maxSpeed;
		public float volumeMulti;
		public AnimationCurve VelocityPitchCurve;
		public AudioMixerGroup outputMixer;
		public float realtimeWhooshUpdateFrequency;
		[SerializeField]
		private PhysHand _physHand;
	}
}
