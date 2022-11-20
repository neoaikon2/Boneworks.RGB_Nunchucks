using UnityEngine;
using System.Collections.Generic;

namespace StressLevelZero.Arena
{
	public class Arena_Challenge : ScriptableObject
	{
		public enum ChallengeDifficulty
		{
			EASY = 0,
			MEDIUM = 1,
			HARD = 2,
			EASY_T2 = 3,
			MEDIUM_T2 = 4,
			HARD_T2 = 5,
		}

		public enum ChallengeType
		{
			CHALLENGE = 0,
			TRIAL = 1,
		}

		public ChallengeDifficulty challengeDifficulty;
		public Sprite unlockedSprite;
		public int level;
		public Arena_TrialsProfile profile;
		public ChallengeType challengeType;
		public string description;
		public Arena_GameManager.ArenaGameMode gameMode;
		public Arena_WeaponSpawner.WeaponModeType weaponModeType;
		public List<Arena_RoundProfile> easyRoundProfile;
		public List<Arena_RoundProfile> mediumRoundProfile;
		public List<Arena_RoundProfile> hardRoundProfile;
		public List<Arena_RoundProfile> easyRoundProfile_T2;
		public List<Arena_RoundProfile> mediumRoundProfile_T2;
		public List<Arena_RoundProfile> hardRoundProfile_T2;
	}
}
