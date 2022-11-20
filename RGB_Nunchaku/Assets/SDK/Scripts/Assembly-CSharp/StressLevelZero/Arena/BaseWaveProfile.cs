using System;
using System.Collections.Generic;

namespace StressLevelZero.Arena
{
	[Serializable]
	public class BaseWaveProfile
	{
		public bool showWave;
		public int enemyCount;
		public List<EnemyProfile> enemyProfilesList;
	}
}
