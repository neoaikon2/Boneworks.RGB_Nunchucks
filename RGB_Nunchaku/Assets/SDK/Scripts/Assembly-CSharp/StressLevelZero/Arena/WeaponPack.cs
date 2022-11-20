using UnityEngine;
using StressLevelZero.Data;
using StressLevelZero.Interaction;
using StressLevelZero.Props.Weapons;

namespace StressLevelZero.Arena
{
	public class WeaponPack : MonoBehaviour
	{
		public enum WeaponType
		{
			RANGED = 0,
			MELEE = 1,
		}

		public enum MeleeType
		{
			BLADE = 0,
			BLUNT = 1,
		}

		public WeaponType weaponType;
		public MeleeType meleeType;
		public WeaponPack secondaryPack;
		public SpawnableObject weaponDataObject;
		public SpawnableObject magazineDataObject;
		public GameObject weaponPrefab;
		public GameObject spawnedWeaponObj;
		public GameObject spawnedMagObj;
		public Transform weaponSpawn;
		public Transform magazineSpawn;
		public InteractableHost weaponHost;
		public Gun gun;
		public Grip weaponGrip;
		public MagazineSocket slotReciever;
		public Rigidbody gunBody;
		public Magazine magazine;
		public Grip magGrip;
		public InteractableHost magHost;
		public Rigidbody magBody;
		[SerializeField]
		private GameObject _holoWeaponObj;
		[SerializeField]
		private GameObject _holoMagObj;
	}
}
