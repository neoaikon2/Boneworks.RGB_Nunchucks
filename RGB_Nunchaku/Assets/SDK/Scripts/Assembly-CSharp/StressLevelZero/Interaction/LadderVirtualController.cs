using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.Interaction
{
	public class LadderVirtualController : MonoBehaviour
	{
		public Vector3 direction;
		public Vector3 normal;
		public HandPose handPose;
		public PhysicMaterial ladderFeetPhysicMaterial;
		public float sideMemberOffset;
		public float sideMemberHeight;
		public float sideMemberWidth;
		public float sideMemberRadius;
		public float rungHeight;
		public float rungWidth;
		public float rungRadius;
		public float rungOffset;
		public int rungCount;
		public Transform firstRung;
	}
}
