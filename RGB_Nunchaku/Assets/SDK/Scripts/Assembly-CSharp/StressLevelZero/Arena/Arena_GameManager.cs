using UnityEngine;
using StressLevelZero.Data;
using System.Collections.Generic;
using UnityEngine.Audio;
using StressLevelZero.SFX;
using StressLevelZero.Combat;
using TMPro;
using StressLevelZero.AI;
using PuppetMasta;

namespace StressLevelZero.Arena
{
	public class Arena_GameManager : MonoBehaviour
	{
		public enum WeaponModeFlags
		{
			FISTS = 0,
			HANDGUN = 2,
			SMG = 4,
			RIFLE = 8,
			BLADE = 16,
			BLUNT = 32,
			ALL_WEAPONS = -1,
		}

		public enum ArenaGameMode
		{
			SURVIVAL = 0,
			PROTECT = 1,
			WEAPON = 2,
			STORY = 3,
			INSTA_DEATH = 4,
			BOXING = 5,
			CRABSKETBALL = 6,
			BALLOON_GUN = 7,
			DEATHMATCH = 8,
			INFINITE_AMMO = 9,
			BRAWL = 10,
		}

		public bool visDebug;
		public bool isPlayerInWeaponRoom;
		public bool isChallengeActive;
		[SerializeField]
		private bool isSlowTime;
		public ArenaGameMode arenaGameMode;
		public WeaponModeFlags arenaWeaponFlags;
		public float waveTimeElapsed;
		public float totalTimeElapsed;
		public int round;
		public int wave;
		public bool canForceStop;
		public bool isWaveOngoing;
		public bool isForceEnding;
		public SpawnableObject bloodSplatterSpawnable;
		public Player_Health playerHealth;
		public List<Arena_Challenge> masterChallengeList;
		public List<Arena_Challenge> challengeList;
		public List<Arena_Challenge> trialList;
		public Arena_Challenge activeChallenge;
		public Arena_RoundProfile currentRoundProfile;
		public List<Arena_RoundProfile> roundProfileList;
		public Arena_SpawnEnemies enemySpawner;
		public int chance;
		public AudioMixerGroup audioGroup;
		public HeadSFX headSFX;
		public AudioClip roundFailClip;
		public AudioClip[] roundEndClips;
		public AudioClip[] waveStartClips;
		public AudioClip[] waveEndClips;
		public AudioClip playerAcknowledgeClip;
		public AudioClip medievalLoopClip;
		public AudioClip medievalIntenseClip;
		[SerializeField]
		private AudioClip[] intenseAudioClips;
		public AudioClip hornClip;
		public Arena_DoorController[] arenaDoors;
		public Arena_PlayerTrigger startNextRoundTrigger;
		public Arena_DoorController southDoorControl;
		public Arena_DoorController northDoorControl;
		public GameObject northEnergyWall;
		[SerializeField]
		private Arena_BellInteractable bellInteractable;
		public MeshRenderer stopButtonLightMR;
		public bool isRung;
		public Arena_Launcher launcher;
		public List<ProjectileBalloon_Arena> balloonList;
		[SerializeField]
		private List<ProjectileBalloon_Arena> playerBalloonList;
		public List<GameObject> cageList;
		public List<Transform> allCageTransforms;
		public List<Vector3> cagePosList;
		public GameObject balloon_UI;
		public TMP_Text balloonTimerText;
		public Transform crabsketballEnemyGoal;
		public GameObject backBoardEnemy;
		public GameObject backBoardPlayer;
		public GameObject crabsketball_UI;
		public TMP_Text enemyScoreText;
		public TMP_Text playerScoreText;
		public TMP_Text goalScoreText;
		public List<TriggerRefProxy> friendlyProxyList;
		public List<Arena_EnemyReference> enemyRefs;
		public List<Arena_EnemyReference> despawnedEnemyRefs;
		public List<PuppetMaster> allPuppets;
		public List<PuppetMaster> alivePuppets;
		public List<Arena_EnemyReference> westDoorEnemies;
		public List<Arena_EnemyReference> northDoorEnemies;
		public List<Arena_EnemyReference> eastDoorEnemies;
		public int waveEnemyCount;
		public List<Arena_EnemyReference> friendlyEnemyRefList;
		public TriggerRefProxy playerProxy;
		public float throwerSpawnTime;
		public Control_UI_Arena arenaChallengeUI;
		public GameObject wave_UI_Prefab;
		public List<Arena_UI> arena_UI_Blocks;
		public GameObject ui_ParentObj;
		public Transform UI_Start;
		public Canvas arenaCanvas;
		public int UI_Block_Y_Size;
		public Texture buttonTextureCrab;
		public Texture buttonTextureCrabDead;
		public Texture buttonTextureCrabPooled;
		public Texture buttonTextureBrett;
		public Texture buttonTextureBrettDead;
		public Texture buttonTextureBrettPooled;
		public Texture buttonTextureZombie;
		public Texture buttonTextureZombieDead;
		public Texture buttonTextureZombiePooled;
		public Texture buttonTextureNullBody;
		public Texture buttonTextureNullBodyDead;
		public Texture buttonTextureNullBodyPooled;
		public Arena_WeaponSpawner weaponSpawner;
		[SerializeField]
		private Material darkScreenMat;
		[SerializeField]
		private Material ogScreenMat;
		[SerializeField]
		private MeshRenderer[] screenRends;
		[SerializeField]
		private SwitchFog switchFog;
		[SerializeField]
		private GameObject realTimeLightsObj;
		public int crabsKilled;
	}
}
