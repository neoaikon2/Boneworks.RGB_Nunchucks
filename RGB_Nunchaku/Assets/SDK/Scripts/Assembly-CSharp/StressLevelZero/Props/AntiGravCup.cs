using UnityEngine;
using StressLevelZero.Interaction;

namespace StressLevelZero.Props
{
	public class AntiGravCup : MonoBehaviour
	{
		public bool antiGravity;
		public float radius;
		public Vector3 halfExtents;
		public LayerMask effectedLayers;
		public Grip triggerGrip;
		public Grip secondaryTriggerGrip;
		public Transform cupSurfaceTransform;
	}
}
