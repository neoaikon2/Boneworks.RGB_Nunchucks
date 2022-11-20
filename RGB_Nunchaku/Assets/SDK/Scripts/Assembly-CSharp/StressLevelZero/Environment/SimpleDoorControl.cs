using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.Environment
{
	public class SimpleDoorControl : MonoBehaviour
	{
		public bool isLocked;
		public AudioClip[] closeClip;
		public AudioClip[] slamClip;
		public AudioClip[] openClip;
		public AudioClip[] audioClip;
		public AudioClip[] lockClip;
		public ConfigurableJoint joint;
		public Rigidbody doorRigidbody;
		public Transform hingeBack;
		public Transform hingeForward;
		public Transform connectedHingeBack;
		public Transform connectedHingeForward;
		public Transform hingeArtTransform;
		public Collider[] ignoreColliders;
		public UnityEvent onLocked;
		public UnityEvent onUnlocked;
		public UnityEvent onClose;
	}
}
