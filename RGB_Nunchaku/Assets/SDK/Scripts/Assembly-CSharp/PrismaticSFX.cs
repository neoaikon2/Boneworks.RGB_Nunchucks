using UnityEngine;
using System;
using UnityEngine.Audio;

public class PrismaticSFX : MonoBehaviour
{
	[Serializable]
	public class AudioEvent
	{
		public bool eventEnabled;
		public Transform eventTran;
		public AudioClip[] eventClip;
		public float minSpeed;
		public float maxSpeed;
		public float triggerDistance;
	}

	public Rigidbody rb_parent;
	public Transform velocityTran;
	public Transform sourceTran;
	public float minSpeed;
	public float maxSpeed;
	public float sourceMinDistance;
	public float pitchMod;
	public AudioMixerGroup outputMixer;
	public bool enableModulatedAudio;
	public bool loopClips;
	public AudioClip[] modulatedClips;
	public bool enableEvents;
	public AudioEvent[] audioEvents;
	[SerializeField]
	private bool _blockJointBreakStop;
}
