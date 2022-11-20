using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.SFX
{
	public class RollingSFX : MonoBehaviour
	{
		public Rigidbody[] wheels;
		public AudioMixerGroup outputMixer;
		public GameObject sourceObj;
		public float maxAngularV;
		public float realtimeUpdateFrequency;
		public float wheelRadius;
		public float minSpeed;
		public float maxSpeed;
		public AudioClip spinningNotColliding;
		public AudioClip rollingWithCollision;
	}
}
