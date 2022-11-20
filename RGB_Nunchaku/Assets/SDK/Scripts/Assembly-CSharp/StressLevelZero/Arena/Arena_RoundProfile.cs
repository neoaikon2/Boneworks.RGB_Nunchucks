using System;
using System.Collections.Generic;

namespace StressLevelZero.Arena
{
	[Serializable]
	public class Arena_RoundProfile
	{
		public enum LootWeapons
		{
			EDER_PISTOL = 0,
			UZI_SMG = 1,
			MP5K_SMG = 2,
			M16_RIFLE = 3,
			MK18_RIFLE = 4,
			RANDOM_WEAPON = 5,
		}

		public bool showRound;
		public Arena_GameManager.WeaponModeFlags roundWeapons;
		public LootWeapons lootWeapon;
		public int lootCrateChance;
		public List<BaseWaveProfile> waveGroupList;
		public int waitTimeSpawn;
	}
}
