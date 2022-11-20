using UnityEngine;

namespace StressLevelZero.Zones
{
	public class ZoneLight : ZoneItem
	{
		[SerializeField]
		private bool PrimeZoneOnly;
		[SerializeField]
		private float SpotLightAngle;
		[SerializeField]
		private float LightRange;
		[SerializeField]
		private float LightIntensity;
		[SerializeField]
		private Color LightColor;
		[SerializeField]
		private bool EnableShadows;
		[SerializeField]
		public bool cookieEnabled;
		[SerializeField]
		public int cookieNumber;
		[SerializeField]
		public float OverallTransitionTime;
		[SerializeField]
		public float outTransitionTime;
		[SerializeField]
		public float inTransitionTime;
		[SerializeField]
		private GameObject LightObject;
		[SerializeField]
		private Light SourceLight;
		[SerializeField]
		private ValveRealtimeLight realtimeLight;
	}
}
