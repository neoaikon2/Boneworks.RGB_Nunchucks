using UnityEngine;

namespace Boneworks
{
	public class SLZ_LaserPointer : MonoBehaviour
	{
		public Transform laserLine;
		public Transform glowingPoint;
		public Renderer[] renderers;
		public TrailRenderer trail;
		public float RaycastDistance;
		[SerializeField]
		private LayerMask Masks;
		[SerializeField]
		private int FrameSkip;
	}
}
