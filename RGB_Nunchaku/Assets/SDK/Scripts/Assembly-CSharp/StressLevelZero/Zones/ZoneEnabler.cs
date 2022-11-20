using UnityEngine;

namespace StressLevelZero.Zones
{
	public class ZoneEnabler : ZoneItem
	{
		[SerializeField]
		private bool PrimeZoneOnly;
		[SerializeField]
		private GameObject[] Objects;
	}
}
