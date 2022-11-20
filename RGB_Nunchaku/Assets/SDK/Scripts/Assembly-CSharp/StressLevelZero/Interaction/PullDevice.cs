using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Audio;

namespace StressLevelZero.Interaction
{
	public class PullDevice : MonoBehaviour
	{
		public AudioClip[] pullClips;
		public AudioClip[] releaseClips;
		public Grip grip;
		public ConfigurableJoint joint;
		public Rigidbody rb;
		public float distance;
		public UnityEvent OnHandlePull;
		public UnityEvent OnHandleReturn;
		public AudioMixerGroup mixerGroup;
	}
}
