using UnityEngine;

namespace StressLevelZero.AI
{
	public class TriggerManager : MonoBehaviour
	{
		public enum TriggerTypes
		{
			Sphere = 1,
			Cone = 2,
		}

		public enum TargetTypes
		{
			Sphere = 1,
		}

		public int defaultBufferSize;
	}
}
