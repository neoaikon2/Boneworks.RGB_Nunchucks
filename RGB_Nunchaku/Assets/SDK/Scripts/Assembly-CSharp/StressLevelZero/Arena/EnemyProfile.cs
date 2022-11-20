using System;

namespace StressLevelZero.Arena
{
	[Serializable]
	public class EnemyProfile
	{
		public enum EntranceType
		{
			NorthDoor = 0,
			EastDoor = 1,
			WestDoor = 2,
			RandomDoor = 3,
			HoiPoi = 4,
		}

		public bool showEnemy;
		public Arena_EnemyReference.EnemyType enemyType;
		public EntranceType entranceType;
	}
}
