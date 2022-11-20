using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.Combat
{
	[CreateAssetMenu(menuName = "Magazine Data", fileName = "New MagazineData")]
	public class MagazineData : ScriptableObject
	{
		public SpawnableObject spawnableObject;
		public Weight weight;
		public Cart cartridgeType;
		public Platform platform;
		public BulletObject[] AmmoSlots;
	}
}
