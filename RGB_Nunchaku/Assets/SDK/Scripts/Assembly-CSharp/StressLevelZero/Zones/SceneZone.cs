using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;
using StressLevelZero;

namespace StressLevelZero.Zones
{
	public class SceneZone : MonoBehaviour
	{
		[SerializeField]
		public BoxCollider boxCollider;
		public SceneZone[] linkedZones;
		public List<ZoneItem> zoneItems;
		public UnityEvent onZoneEnabled;
		public UnityEvent onZoneDisabled;
		public UnityEvent onPrimaryZoneEntered;
		public UnityEvent onPrimaryZoneExited;
		public UnityEvent onSecondaryZoneEntered;
		public UnityEvent onSecondaryZoneExited;
		public UnityEvent onPrimaryZoneEnteredOneTime;
		public UnityEvent onSecondaryZoneEnteredOneTime;
		public SaveItem saveItem;
	}
}
