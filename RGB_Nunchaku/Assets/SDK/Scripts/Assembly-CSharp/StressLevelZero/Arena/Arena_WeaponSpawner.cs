using UnityEngine;
using StressLevelZero.Interaction;
using System.Collections.Generic;
using StressLevelZero.Props.Weapons;
using StressLevelZero.Rig;
using StressLevelZero.UI;
using StressLevelZero.Data;
using StressLevelZero;
using UnityEngine.Audio;

namespace StressLevelZero.Arena
{
	public class Arena_WeaponSpawner : MonoBehaviour
	{
		public enum WeaponModeType
		{
			RANGED = 0,
			MELEE = 1,
			RANGED_AND_MELEE = 2,
		}

		[SerializeField]
		private bool spawnSecondaryPistolsByDefault;
		[SerializeField]
		private GameObject playerRigObj;
		public Hand rightHand;
		public Hand leftHand;
		public List<HandWeaponSlotReciever> weaponSlotRecieverList;
		public RealtimeSkeletonRig playerSkelRig;
		public GameObject pRelativePrefab;
		public PlayerRelativeGunSpawns pRelativeGunSpawnRef;
		public Control_GlobalTime globalTimeControl;
		public Rigidbody playerPhysPelvisBody;
		public List<WeaponPack> currentWepModePackList;
		public Transform playerHead;
		[SerializeField]
		private UIControllerInput leftInput;
		[SerializeField]
		private UIControllerInput rightInput;
		[SerializeField]
		private GameObject playerObj;
		public bool visDebug;
		public List<WeaponPack> weaponPackList;
		public List<WeaponPack> weaponModeRangedList;
		public List<WeaponPack> weaponModeMeleeList;
		public Arena_GeoManager geoManager;
		public WeaponPack ederPistol_Pack;
		public WeaponPack nineteenElevenPistol_Pack;
		public WeaponPack P350Pistol_pack;
		public WeaponPack uziSMG_Pack;
		public WeaponPack mp5kSMG_Pack;
		public WeaponPack mp5kSMG_FlashlightPack;
		public WeaponPack mp5kSMG_PlasticPack;
		public WeaponPack mp5kSMG_RedDotPack;
		public WeaponPack mp5SMG_Pack;
		public WeaponPack m16Rifle_Pack;
		public WeaponPack m16_IronSight_Rifle_Pack;
		public WeaponPack m16_ACOG_Rifle_Pack;
		public WeaponPack m16_LaserSight_Rifle_Pack;
		public WeaponPack mk18Rifle_Pack;
		public WeaponPack mk18_Sabre_Rifle_Pack;
		public WeaponPack mk18_Holo_Rifle_Pack;
		public WeaponPack mk18_Laser_Rifle_Pack;
		public WeaponPack vikingShield_Pack;
		public WeaponPack daggerBlade_Pack;
		public WeaponPack bastardBlade_Pack;
		public WeaponPack lootCrate_Pack;
		public SpawnableObject mediumAmmoCrate;
		public SpawnableObject smallAmmoCrate;
		public SpawnableObject lootCrateOD;
		public SpawnableObject balloonGunObject;
		public SpawnableObject powerPuncherSpawnable;
		public Transform[] ammoSpawns;
		public Transform gravGunSpawn;
		public Transform weaponModeGunSpawn;
		public Transform weaponModeMagSpawn;
		public Transform balloonGunSpawn;
		public Transform powerPunchSpawnLeft;
		public Transform powerPunchSpawnRight;
		[SerializeField]
		private Arena_Volume lootCrateVolume;
		[SerializeField]
		private Arena_Volume altLootCrateVolume;
		[SerializeField]
		private Arena_Volume pitLootCrateVolume;
		[SerializeField]
		private Arena_Volume altPitLootCrateVolume;
		public GameObject spawnedCrate;
		public GameObject spawnedGravGun;
		public GameObject spawnedBalloonGun;
		public GameObject spawnedCrateMedium;
		public GameObject spawnedCrateSmall;
		public GameObject spawnedLightAmmoObj;
		public GameObject spawnedMedAmmoObj;
		public AmmoPickup lightAmmoPickup;
		public AmmoPickup medAmmoPickup;
		[SerializeField]
		private AudioClip dropClip;
		[SerializeField]
		private AudioMixerGroup audioGroup;
		[SerializeField]
		private Material holoMat;
	}
}
