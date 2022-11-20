using System;
using UnityEngine.Events;
using UnityEngine;

namespace StressLevelZero.Zones
{
	public class ZoneItemHelper : ZoneItem
	{
		[Serializable]
		public class ZoneItemHelperEvent : UnityEvent<GameObject>
		{
		}

		public ZoneItemHelperEvent onZoneEnabledDelegate;
		public ZoneItemHelperEvent onZoneDisabledDelegate;
		public ZoneItemHelperEvent onSecondaryZoneEnteredDelegate;
		public ZoneItemHelperEvent onSecondaryZoneExitedDelegate;
		public ZoneItemHelperEvent onPrimaryZoneEnteredDelegate;
		public ZoneItemHelperEvent onPrimaryZoneExitedDelegate;
	}
}
