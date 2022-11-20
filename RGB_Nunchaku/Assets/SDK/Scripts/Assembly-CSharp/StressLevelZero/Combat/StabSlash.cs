using UnityEngine;
using System;
using UnityEngine.Audio;
using StressLevelZero.Interaction;

namespace StressLevelZero.Combat
{
	public class StabSlash : MonoBehaviour
	{
		[Serializable]
		public class BladeAudio
		{
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
			public AudioClip[] cutEnd;
			public Transform whooshTran;
			public AudioClip whooshLoop;
			public Collider[] hiltColliders;
			public float bluntDamageMult;
			public float nativeImpactVelocity;
			public float impactVelocityThresh;
			public float cutAccelThresh;
		}

		[Serializable]
		public class StabPoint
		{
			[Serializable]
			public class StabJoint
			{
				public ConfigurableJoint joint;
				public Collider collider;
				public float megaPascals;
				public ImpactProperties iP;
				public bool firstFrame;
				public float depth;
				public float deepestDepth;
				public float velocity;
				public float damageBuffer;
			}

			public Transform pointTran;
			public Collider pointCollider;
			public float maxDepth;
			public float aspectRatio;
			public float stabBreakForce;
			public float sharpness;
			public float depthResistanceMult;
			public float linearSpring;
			public float linearDamp;
			public float damage;
			public StabJoint[] stabJoints;
			public int impaleCount;
			public InteractableHost _host;
			public StabSlash.BladeAudio bAudio;
		}

		[Serializable]
		public class SlashBlade
		{
			[Serializable]
			public class BladeJoint
			{
				public ConfigurableJoint joint;
				public Collider collider;
				public float megaPascals;
				public ImpactProperties iP;
				public bool firstFrame;
				public float velocity;
				public float damageBuffer;
			}

			public Transform bladeTran;
			public Collider bladeCollider;
			public float bladeLength;
			public float maxDepth;
			public float bladeBreakForce;
			public float sharpness;
			public float linearSpring;
			public float linearDamp;
			public float damage;
			public BladeJoint[] bladeJoints;
			public int impaleCount;
			public InteractableHost _host;
			public StabSlash.BladeAudio bAudio;
		}

		public StabPoint[] stabPoints;
		public SlashBlade[] slashBlades;
		public BladeAudio bladeAudio;
	}
}
