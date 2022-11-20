using UnityEngine;
using StressLevelZero;

namespace StressLevelZero.Rig
{
	public class SkeletonHand : MonoBehaviour
	{
		public RigManager manager;
		public Transform rigTransform;
		public Handedness handedness;
		public Quaternion offsetRotation;
		public Vector3 overridePosition;
		public Quaternion overrideRotation;
	}
}
