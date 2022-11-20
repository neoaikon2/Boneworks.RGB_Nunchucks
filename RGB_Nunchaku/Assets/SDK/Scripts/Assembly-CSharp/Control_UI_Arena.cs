using UnityEngine;
using StressLevelZero.Arena;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class Control_UI_Arena : MonoBehaviour
{
	public bool visDebug;
	public Arena_Stats arenaStats;
	public Arena_Challenge activeChallenge;
	public Image activeChallengeImage;
	public UIHapticHoverArena[] hapticHovers;
	public Image completedEasyImage;
	public Image completedMedImage;
	public Image completedHardImage;
	public GameObject cancelButtonObj;
	public GameObject resumeSurvivalButtonObj;
	public Arena_DoorController playerDoorController;
	public Arena_GeoManager geoManager;
	public TextMeshPro alliesCountText;
	public int alliesCount;
	public int maxAllies;
	public GameObject homePageObj;
	public GameObject trialsPageObj;
	public GameObject difficultyPageObj;
	public GameObject ActiveChallengePageObj;
	public TextMeshPro trialsDescriptionText;
	public TextMeshPro challengeDescriptionText;
	public TextMeshPro activeChallengeText;
	public TextMeshPro activeChallengeDifficulty;
	public TextMeshPro surivalRoundAchievedText;
	public TextMeshPro survivalTimeAchievedText;
	public TextMeshPro activeChallengeDescriptionText;
	public TextMeshPro hardwareTierText;
	[SerializeField]
	private Image[] allySprites;
	public Arena_Challenge customBrawlChallenge;
	[SerializeField]
	private bool closedGateExists;
	[SerializeField]
	private TextMeshPro highEnemyWarningText;
	public List<Arena_EnemyReference.EnemyType> allEnemyTypes;
	public List<Arena_EnemyReference.EnemyType> nonFriendlyEnemyTypes;
	public Arena_EnemyReference.EnemyType westDoorEnemyType;
	public Arena_EnemyReference.EnemyType northDoorEnemyType;
	public Arena_EnemyReference.EnemyType eastDoorEnemyType;
	[SerializeField]
	private TextMeshPro maxEnemyText;
	[SerializeField]
	private TextMeshPro weaponsText;
	[SerializeField]
	private TextMeshPro eastDoorEnemyTypeText;
	[SerializeField]
	private TextMeshPro eastDoorEnemyCountText;
	[SerializeField]
	private TextMeshPro northDoorEnemyTypeText;
	[SerializeField]
	private TextMeshPro northDoorEnemyCountText;
	[SerializeField]
	private TextMeshPro westDoorEnemyTypeText;
	[SerializeField]
	private TextMeshPro westDoorEnemyCountText;
}
