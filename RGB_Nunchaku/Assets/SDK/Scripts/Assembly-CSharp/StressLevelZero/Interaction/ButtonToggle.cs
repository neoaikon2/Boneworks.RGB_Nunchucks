using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace StressLevelZero.Interaction
{
	public class ButtonToggle : MonoBehaviour
	{
		public ConfigurableJoint joint;
		public Transform endTransform;
		public AudioClip[] pressClips;
		public AudioClip[] depressClips;
		public AudioMixerGroup mixerGroup;
		public Collider[] ignoreColliders;
		public Collider buttonShaftCollider;
		public UnityEvent onPress;
		public UnityEvent onDepress;
		public UnityEvent onHold;
		public UnityEvent onPressOneShot;
	}
}
