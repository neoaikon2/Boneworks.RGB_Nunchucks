using UnityEngine;

namespace StressLevelZero.Zones
{
	public class ZoneItem : MonoBehaviour
	{
		public enum TriggerOptions
		{
			NONE = 1,
			PRIMARY = 2,
			SECONDARY = 4,
		}

		public bool inSecondaryZone;
		public bool isEnabled;
		public SceneZone zone;
		public TriggerOptions triggerOption;
	}
}
