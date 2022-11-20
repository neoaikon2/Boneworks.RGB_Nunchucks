using StressLevelZero.Combat;
using StressLevelZero.Data;
using StressLevelZero.SFX;

namespace StressLevelZero.Interaction
{
	public class MagazineSocket : Socket
	{
		public MagazineData magazineData;
		public bool isInfiniteAmmo;
		public bool requireExit;
		public SpawnableObject spawnableMagazine;
		public Grip primaryGrip;
		public BulletObject defaultBullet;
		public GunSFX sfx;
		public bool isActive;
	}
}
