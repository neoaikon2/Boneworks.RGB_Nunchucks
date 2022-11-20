using UnityEngine;
using StressLevelZero.Rig;
using TMPro;
using System.Collections.Generic;
using UnityEngine.UI;
using StressLevelZero.AI;
using StressLevelZero.Data;
using PuppetMasta;
using StressLevelZero.Arena;
using UnityEngine.Audio;
using StressLevelZero.SFX;
using StressLevelZero.Props.Weapons;

public class Zombie_GameControl : MonoBehaviour
{
	public enum GameMode
	{
		SURVIVAL = 0,
		THE_CURE = 1,
		CUSTOM = 2,
		LOCKOUT = 3,
		BLADES_N_BLUNTS = 4,
	}

	public enum Difficulty
	{
		EASY = 0,
		MEDIUM = 1,
		HARD = 2,
		HARDER = 3,
		HARDEST = 4,
	}

	public enum Loadout
	{
		COMBAT = 0,
		CLEAVER = 1,
		HAMMER = 2,
	}

	public GameMode gameMode;
	public Difficulty difficulty;
	public Loadout loadout;
	public Player_Health.HealthMode healthMode;
	[SerializeField]
	private Player_Health _playerHealth;
	[SerializeField]
	private float timeBetweenWaves;
	[SerializeField]
	private float startTimer;
	public bool isWaveOngoing;
	[SerializeField]
	private bool isSlowTime;
	[SerializeField]
	private GameObject combatLoadout;
	[SerializeField]
	private GameObject butcherLoadout;
	[SerializeField]
	private GameObject hammerLoadout;
	[SerializeField]
	private GameObject katanaLoadout;
	[SerializeField]
	private GameObject swordLoadout;
	[SerializeField]
	private GameObject axeLoadout;
	[SerializeField]
	private GameObject[] defaultWeps;
	[SerializeField]
	private GameObject[] meleeWeps;
	[SerializeField]
	private GameObject[] specialWeps;
	[SerializeField]
	private GameObject[] ammoPickups;
	[SerializeField]
	private Zombie_PlayerTrigger[] spawnTriggers;
	[SerializeField]
	private Zombie_PlayerTrigger roofTriggerSpawn;
	[SerializeField]
	private Zombie_PlayerTrigger containerTriggerSpawn;
	[SerializeField]
	private GameObject reclaimBinObj;
	[SerializeField]
	private bool limitedSlowMo;
	[SerializeField]
	private float maxSlowMoJuice;
	[SerializeField]
	private float slowMoJuice;
	[SerializeField]
	private SpriteRenderer[] timeBipSprites;
	[SerializeField]
	private GameObject slowMoSlider;
	[SerializeField]
	private GameObject slowMoHUD;
	[SerializeField]
	private Control_GlobalTime timeControl;
	[SerializeField]
	private ControllerRig controllerRig;
	[SerializeField]
	private TMP_Text slowMoButtonText;
	[SerializeField]
	private SpriteRenderer[] slowHubRends;
	[SerializeField]
	private AudioClip slowMoCoolClip;
	[SerializeField]
	private AudioClip slowMoJuicedClip;
	[SerializeField]
	private TMP_Text killsText;
	[SerializeField]
	private TMP_Text[] timerTexts;
	[SerializeField]
	private TMP_Text[] modeTexts;
	[SerializeField]
	private TMP_Text[] waveTexts;
	[SerializeField]
	private TMP_Text[] remainingEnemiesTexts;
	[SerializeField]
	private TMP_Text descriptionText;
	[SerializeField]
	private TMP_Text gamePlayDescriptionText;
	[SerializeField]
	private TMP_Text diffText;
	[SerializeField]
	private TMP_Text gamePageDiffText;
	[SerializeField]
	private TMP_Text healthModeText;
	[SerializeField]
	private GameObject uiSelectPageObj;
	[SerializeField]
	private GameObject uiGameDisplayPageObj;
	[SerializeField]
	private List<GameObject> prevPageObjList;
	[SerializeField]
	private GameObject[] uiInteractableObjs;
	[SerializeField]
	private TMP_Text healthDesText;
	[SerializeField]
	private TMP_Text diffDescriptionText;
	[SerializeField]
	private Image[] checkSprites;
	[SerializeField]
	private GameObject[] loadOutlines;
	[SerializeField]
	private GameObject startGameButtonObj;
	[SerializeField]
	private GameObject customGameButtonObj;
	public List<Arena_EnemyReference.EnemyType> customEnemyTypeList;
	public GameObject[] enemyCheckMarkObjs;
	[SerializeField]
	private GameObject gunLoadoutObj;
	[SerializeField]
	private GameObject meleeLoadoutObj;
	public bool isSpawning;
	[SerializeField]
	private int activeEnemyCount;
	[SerializeField]
	private int totalKillCount;
	[SerializeField]
	private int totalEnemyCount;
	public TriggerRefProxy playerProxy;
	public int currWaveIndex;
	public bool isWaiting;
	[SerializeField]
	private bool insideSpawnA;
	public List<Arena_EnemyReference> enemyRefList;
	[SerializeField]
	private List<Arena_EnemyReference> activeEnemyList;
	public Transform[] zoneA_SpawnPoints;
	public Transform[] zoneB_SpawnPoints;
	[SerializeField]
	private SpawnableObject fordSpawnableObject;
	[SerializeField]
	private SpawnableObject zombieSpawnableObject;
	[SerializeField]
	private SpawnableObject nullBodySpawnableObject;
	[SerializeField]
	private SpawnableObject omniSpawnableObject;
	[SerializeField]
	private SpawnableObject crabletSpawnableObject;
	[SerializeField]
	private SpawnableObject crabletPlusSpawnableObject;
	[SerializeField]
	private SpawnableObject shortHairedFordSpawnableObject;
	[SerializeField]
	private BaseEnemyConfig zombieBaseConfig;
	[SerializeField]
	private BaseEnemyConfig zombieThrowerBaseConfig;
	[SerializeField]
	private SpawnableObject smallHealthSpawnable;
	[SerializeField]
	private SpawnableObject largeHealthSpawnable;
	[SerializeField]
	private Arena_RoundProfile roundProfile;
	[SerializeField]
	private GameObject playerRig;
	[SerializeField]
	private Transform towerSpawn;
	[SerializeField]
	private Transform roofSpawn;
	[SerializeField]
	private Transform containerSpawn;
	[SerializeField]
	private Transform newZipSpawn;
	[SerializeField]
	private AudioClip waveCompleteClip;
	[SerializeField]
	private AudioClip waveStartClip;
	[SerializeField]
	private AudioMixerGroup softIntAudioGroup;
	public int currClip;
	public List<AudioClip> musicClipsList;
	[SerializeField]
	private HeadSFX headSFX;
	public AudioClip collectAudioClip;
	[SerializeField]
	private CureMachinePowerable cureMachine;
	[SerializeField]
	private int addEnemyCount;
	[SerializeField]
	private GameObject[] garageLeverObjs;
	[SerializeField]
	private GameObject[] quarDoorLeverObjs;
	[SerializeField]
	private List<HandWeaponSlotReciever> weaponSlotRecieverList;
	[SerializeField]
	private GameObject lockoutModeParentObj;
	[SerializeField]
	private GameObject freeModeParentObj;
	[SerializeField]
	private MonomatItemSwapper[] monoItemSwappers;
}
