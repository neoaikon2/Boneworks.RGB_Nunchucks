using UnityEngine;

namespace StressLevelZero.VRMK
{
	public class PhysBody : MonoBehaviour
	{
		public float footSupported;
		public ConfigurableJoint headJoint;
		public ConfigurableJoint pelvisJoint;
		public GameObject knee;
		public GameObject feet;
		public CapsuleCollider kneePelvisCol;
		public CapsuleCollider chestCol;
		public CapsuleCollider pelvisCol;
		public CapsuleCollider neckCol;
		public CapsuleCollider lfForearmCol;
		public CapsuleCollider rtForearmCol;
		public BoxCollider lfFingersCol;
		public BoxCollider rtFingersCol;
		public LayerMask fingerColCheckMask;
		public LayerMask footballColCheckMask;
		public float footballRadius;
		public int onLadder;
		public float ladderFade;
		public SLZ_Body body;
		public bool bodyMassNaturalHold;
	}
}
