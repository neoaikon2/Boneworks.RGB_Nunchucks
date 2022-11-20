using UnityEngine;
using StressLevelZero.Data;
using StressLevelZero.Combat;
using StressLevelZero.Interaction;
using StressLevelZero.SFX;
using StressLevelZero.AI;
using StressLevelZero.Zones;

namespace StressLevelZero.Props.Weapons
{
	public class Gun : MonoBehaviour
	{
		public enum AnimationStates
		{
			NONE = 0,
			NEUTRAL = 1,
			SLIDEPULL = 2,
			SLIDEPULLREVERSED = 3,
			SLIDERETURN = 4,
			SLIDERETURNREVERSED = 5,
			SLIDELOCKED = 6,
			SLIDELOCKEDREVERSED = 7,
		}

		public enum SlideStates
		{
			RETURNING = 0,
			RETURNED = 1,
			PULLING = 2,
			PULLED = 3,
			LOCKED = 4,
		}

		public enum HammerStates
		{
			UNCOCKED = 0,
			COCKED = 1,
		}

		public enum CartridgeStates
		{
			NONE = 0,
			UNSPENT = 1,
			SPENT = 2,
		}

		public bool isSilenced;
		public float roundsPerMinute;
		public float muzzleVelocity;
		public bool isAutomatic;
		public bool isManual;
		public CurveData fireCurve;
		public CurveData returnCurve;
		public bool isSlideReleaseOnCollision;
		public MagazineData overrideMagazine;
		public bool isChargedOnStart;
		public SpawnableObject spawnableMagazine;
		public Renderer chargingHandleHelperRenderer;
		public Renderer magazineHelperRenderer;
		public Grip triggerGrip;
		public Grip[] otherGrips;
		public GunSFX gunSFX;
		public TriggerRefProxy proxyOverride;
		public ZoneTracker zoneTracker;
		public MagazineSocket magazineSocket;
		public Transform shoulderPointTransform;
		public Transform shellSpawnTransform;
		public Transform shellOrientationTransform;
		public Transform firePointTransform;
		public GameObject nextShellGameObject;
		public GameObject chamberedCartridgeGameObject;
		public GameObject chamberedBulletGameObject;
		public bool isFiring;
		public AnimationStates animationState;
		public SlideStates slideState;
		public HammerStates hammerState;
		public CartridgeStates cartridgeState;
		public bool isGrabbingStats;
		public AnimationStates lastCompletedAnimation;
	}
}
