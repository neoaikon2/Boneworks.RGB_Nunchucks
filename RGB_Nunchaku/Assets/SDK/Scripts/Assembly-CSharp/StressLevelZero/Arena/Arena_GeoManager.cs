using UnityEngine;
using System.Collections.Generic;

namespace StressLevelZero.Arena
{
	public class Arena_GeoManager : MonoBehaviour
	{
		public enum GeoState
		{
			CLEARED = 0,
			MOVING = 1,
			UP = 2,
			MOVING_TO_CLEAR = 3,
		}

		public GeoState geoState;
		public Arena_ObjectSpawner objectSpawner;
		public List<Arena_GeoMover> geoMoverList;
		public Arena_GeoMover balloonGeoMover;
		public Arena_GeoMover weaponGeoMover;
		public Arena_GeoMover crabsketballGeoMover;
		public Arena_GeoMover protectGeoMover;
		public Arena_GeoMover brawlGeoMover;
		public Arena_GeoMover currOverideGeo;
		public Arena_GeoMover ogFloorMover;
		public Arena_PlayerTrigger pitTrigger;
		public Control_UI_Arena uiControl;
	}
}
