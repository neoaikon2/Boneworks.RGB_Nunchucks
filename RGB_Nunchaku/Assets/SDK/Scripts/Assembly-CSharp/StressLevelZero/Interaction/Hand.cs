using UnityEngine;
using StressLevelZero.VRMK;
using StressLevelZero.Rig;
using StressLevelZero.AI;
using StressLevelZero;
using StressLevelZero.Player;

namespace StressLevelZero.Interaction
{
	public class Hand : MonoBehaviour
	{
		public Collider collider;
		public Quaternion jointStartRotation;
		public ConfigurableJoint joint;
		public Rigidbody rb;
		public PhysHand physHand;
		public RigManager manager;
		public TriggerRefProxy triggerRefProxy;
		public Handedness handedness;
		public Hand otherHand;
		public Transform palmPositionTransform;
		public LayerMask hoverLayerMask;
		public LayerMask playerLayerMask;
		public bool showDebugText;
		public bool spewDebugText;
		public InventorySlot slot;
	}
}
