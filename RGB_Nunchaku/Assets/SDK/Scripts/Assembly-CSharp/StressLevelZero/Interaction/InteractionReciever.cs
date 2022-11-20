using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class InteractionReciever : MonoBehaviour
	{
		public enum GrabbedOptions
		{
			EITHER = 0,
			GRABBED = 1,
			FREE = 2,
		}

		public enum Options
		{
			ONE_AT_A_TIME = 2,
		}

		public GrabbedOptions grabbedOptions;
		public Options options;
	}
}
