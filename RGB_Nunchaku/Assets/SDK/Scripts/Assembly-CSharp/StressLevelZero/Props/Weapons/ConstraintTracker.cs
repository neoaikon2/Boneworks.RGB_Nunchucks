using UnityEngine;

namespace StressLevelZero.Props.Weapons
{
	public class ConstraintTracker : MonoBehaviour
	{
		public ConfigurableJoint joint;
		public ConstraintTracker otherTracker;
		public Constrainer source;
		public int index;
		public Constrainer.ConstraintMode mode;
		public Transform attachPoint;
		public LineRenderer lineRenderer;
		public bool isHost;
	}
}
