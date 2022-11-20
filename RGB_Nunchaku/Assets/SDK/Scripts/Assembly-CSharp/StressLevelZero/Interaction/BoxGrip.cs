using StressLevelZero.Data;
using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class BoxGrip : TargetGrip
	{
		public enum Faces
		{
			PositiveX = 1,
			NegativeX = 2,
			PositiveY = 4,
			NegativeY = 8,
			PositiveZ = 16,
			NegativeZ = 32,
		}

		public enum Edges
		{
			PositiveXPositiveY = 1,
			NegativeXPositiveY = 2,
			PositiveXNegativeY = 4,
			NegativeXNegativeY = 8,
			PositiveXPositiveZ = 16,
			NegativeXPositiveZ = 32,
			PositiveXNegativeZ = 64,
			NegativeXNegativeZ = 128,
			PositiveYPositiveZ = 256,
			NegativeYPositiveZ = 512,
			PositiveYNegativeZ = 1024,
			NegativeYNegativeZ = 2048,
		}

		public enum Corners
		{
			PositiveXPositiveYPositiveZ = 1,
			NegativeXPositiveYPositiveZ = 2,
			PositiveXNegativeYPositiveZ = 4,
			NegativeXNegativeYPositiveZ = 8,
			PositiveXPositiveYNegativeZ = 16,
			NegativeXPositiveYNegativeZ = 32,
			PositiveXNegativeYNegativeZ = 64,
			NegativeXNegativeYNegativeZ = 128,
		}

		public float sandwitchSize;
		public float edgePadding;
		public float faceInsetdistance;
		public float faceDepth;
		public HandPose sandwichHandPose;
		public bool canBeSandwichedGrabbed;
		public float sandwhichMinBreakForce;
		public float sandwhichMaxBreakForce;
		public HandPose edgeHandPose;
		public float edgeHandPoseRadius;
		public bool canBeEdgeGrabbed;
		public float edgeMinBreakForce;
		public float edgeMaxBreakForce;
		public HandPose cornerHandPose;
		public float cornerHandPoseRadius;
		public bool canBeCornerGrabbed;
		public float cornerMinBreakForce;
		public float cornerMaxBreakForce;
		public HandPose faceHandPose;
		public float faceHandPoseRadius;
		public bool canBeFaceGrabbed;
		public float faceMinBreakForce;
		public float faceMaxBreakForce;
		[SerializeField]
		public Faces enabledFaces;
		[SerializeField]
		public Edges enabledEdges;
		[SerializeField]
		public Corners enabledCorners;
		[SerializeField]
		private Faces forceGrabFace;
		[SerializeField]
		private Faces forceGrabTop;
		[SerializeField]
		public BoxCollider _boxCollider;
	}
}
