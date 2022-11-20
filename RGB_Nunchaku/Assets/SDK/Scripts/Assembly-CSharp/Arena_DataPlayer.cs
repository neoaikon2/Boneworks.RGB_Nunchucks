using System;
using System.Collections.Generic;

[Serializable]
public class Arena_DataPlayer
{
	public bool isNewSaveFile;
	public Arena_Player_Stats playerStats;
	public List<Arena_RangedWeapon_Stats> rangedWepStats_Data_List;
	public List<Arena_TrialsProfile> challengeProfileList;
}
