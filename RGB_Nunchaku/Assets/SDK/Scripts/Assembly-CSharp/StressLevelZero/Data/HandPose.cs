using UnityEngine;

namespace StressLevelZero.Data
{
	public class HandPose : ScriptableObject
	{
		public string handPoseName;
		public Vector3 angleLimits;
		public Vector3 primaryAxis;
		public Vector3 secondaryAxis;
		public Vector3 wristOffset;
	}
}
