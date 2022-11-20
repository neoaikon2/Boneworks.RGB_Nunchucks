using UnityEngine.Events;
using UnityEngine;

namespace StressLevelZero.Zones
{
	public class ZoneTracker : ZoneItem
	{
		public ZoneSpawner spawner;
		public UnityEvent onDisabledDelegate;
		public UnityEvent onEnabledDelegate;
		[SerializeField]
		private ZoneTrigger _zoneTrigger;
	}
}
