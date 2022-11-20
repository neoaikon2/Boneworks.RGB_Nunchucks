using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.Environment
{
	public class Cart : MonoBehaviour
	{
		public float maxSpeed;
		public float acceleration;
		public Vector3 gateEndPoint;
		public AudioClip launchClip;
		public AudioClip startClip;
		public AudioClip stopClip;
		public AudioMixerGroup mixergroup;
		public Transform gateTransform;
		public Transform endTransform;
		public ConfigurableJoint joint;
		public Rigidbody rb;
	}
}
