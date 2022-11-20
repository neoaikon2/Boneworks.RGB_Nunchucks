using System;

[Serializable]
public class Arena_Player_Stats
{
	public int survivalRoundReached;
	public float survivalTimeReached;
	public int totalBulletsFiredFromAllWeps;
	public int totalEnemyKills;
	public int totalPlayerDeaths;
	public int imminentDeaths;
	public int imminentDeathSaves;
	public float damageTaken;
	public float damageDealt;
	public int totalAliveHits;
	public string favoriteRangedWeapon;
	public int challengePoints;
	public bool isLowEnemyCount;
}
