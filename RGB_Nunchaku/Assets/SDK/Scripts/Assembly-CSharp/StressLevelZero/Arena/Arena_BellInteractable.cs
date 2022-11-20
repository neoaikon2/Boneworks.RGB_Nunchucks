using UnityEngine;
using StressLevelZero.Interaction;

namespace StressLevelZero.Arena
{
	public class Arena_BellInteractable : MonoBehaviour
	{
		public enum BellState
		{
			UP = 0,
			DOWN = 1,
			MOVING = 2,
		}

		public BellState bellState;
		public bool visDebug;
		public float timeToTop;
		public float timeToBottom;
		public BellBodies bellBods;
		public Rigidbody[] bellBodies;
		public CylinderGrip grip;
		public GameObject bellSwingObj;
		public Rigidbody hoverBody;
		public AnimationCurve upCurve;
		public ConfigurableJoint topJoint;
		[SerializeField]
		public GameObject Point1;
		[SerializeField]
		public GameObject Point2;
	}
}
