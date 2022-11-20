using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class MeshGrip : TargetGrip
	{
		public bool autoConfigure;
		public float dynamicFriction;
		public float staticFriction;
		public LayerMask layers;
	}
}
