using UnityEngine;
using StressLevelZero.Data;
using TMPro;
using StressLevelZero.SFX;

public class Control_mainMenuPostGame : MonoBehaviour
{
	//public Data_Manager dataManager;
	public GameObject key_intro_locker;
	public GameObject key_intro_placed;
	public GameObject box_sandboxA;
	public GameObject key_sandboxA_boxed;
	public GameObject key_sandboxA_placed;
	public SpawnableObject spawnable_SandBoxKey;
	public GameObject[] keyport_blank;
	public GameObject[] keyport_pinned;
	public SpawnableObject[] spawnable_sandboxModules;
	public GameObject[] ui_sandboxModules;
	public GameObject[] ui_sandboxModulesLOCKED;
	public GameObject box_arenaA;
	public GameObject key_arenaA_boxed;
	public GameObject key_arenaA_placed;
	public GameObject key_zombieWarehouse_boxed;
	public GameObject key_zombieWarehouse_placed;
	public DoorLightControl[] levelLight;
	public TextMeshProUGUI[] txt_level;
	public bool[] levelUnlocked;
	public string[] levelNames;
	public AudioClip song_mainMenuSong;
	public AudioClip song_rhapsody;
	public ZoneSound zoneMusic;
	public TextMeshProUGUI[] txt_GatesWithAmmo;
	public TextMeshProUGUI[] txt_AmmoSumOfBest;
}
