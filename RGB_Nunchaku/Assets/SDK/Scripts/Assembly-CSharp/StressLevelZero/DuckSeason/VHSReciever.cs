using StressLevelZero.Interaction;
using StressLevelZero.Combat;
using UnityEngine;
using StressLevelZero.SFX;

namespace StressLevelZero.DuckSeason
{
	public class VHSReciever : InteractionReciever
	{
		public Platform platform;
		public bool isInfiniteAmmo;
		public bool disableMagazineGrab;
		public VHSPlayer player;
		public Transform startInsertTarget;
		public Transform endInsertTarget;
		public BulletObject defaultBullet;
		public GunSFX sfx;
		public InteractableHost host;
	}
}
