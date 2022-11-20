using UnityEngine;
using UnityEngine.Events;

namespace Valve.VR.InteractionSystem
{
	public class Throwable : MonoBehaviour
	{
		public Hand.AttachmentFlags attachmentFlags;
		public Transform attachmentOffset;
		public float catchingSpeedThreshold;
		public ReleaseStyle releaseVelocityStyle;
		public float releaseVelocityTimeOffset;
		public float scaleReleaseVelocity;
		public bool restoreOriginalParent;
		public UnityEvent onPickUp;
		public UnityEvent onDetachFromHand;
		public HandEvent onHeldUpdate;
		public Interactable interactable;
	}
}
