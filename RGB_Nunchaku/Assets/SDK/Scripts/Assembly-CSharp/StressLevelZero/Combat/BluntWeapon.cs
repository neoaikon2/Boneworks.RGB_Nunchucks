using UnityEngine;
using System;
using StressLevelZero.Interaction;
using UnityEngine.Audio;

namespace StressLevelZero.Combat
{
	public class BluntWeapon : MonoBehaviour
	{
		[Serializable]
		public class BluntHotSpot
		{
			public InteractableHost m_Host;
			public Transform pointTran;
			public Collider pointCollider;
			public float sharpness;
			public float damage;
			public InteractableHost _host;
		}

		public AudioMixerGroup outputMixer;
		public Transform sourceTran;
		public AudioClip[] hiltImpactSoft;
		public AudioClip[] hiltImpactHard;
		public AudioClip[] bladeImpactSoft;
		public AudioClip[] bladeImpactHard;
		public AudioClip[] fleshCut;
		public AudioClip[] cardboardCut;
		public AudioClip[] woodCut;
		public AudioClip[] metalCut;
		public Transform whooshTran;
		public AudioClip whooshLoop;
		public Collider[] hiltColliders;
		public float bluntDamageMult;
		public float nativeImpactVelocity;
		public float impactVelocityThresh;
		public float cutAccelThresh;
		public BluntHotSpot[] bluntHotSpots;
	}
}
