using StressLevelZero.VRMK;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameControl_MainMenu : GameControl
{
	public BodyVitals ctrl_bodyVitals;
	public GameObject obj_Intro;
	public Transform trn_IntroConnected;
	public Transform trn_IntroDisconnected;
	public TextMeshPro txt_mode;
	public string[] string_modes;
	public GameObject group_GameSelect;
	public GameObject group_LevelSelect;
	public GameObject group_ModSelect;
	public GameObject group_ArenaSelect;
	public GameObject button_Continue;
	public GameObject button_LevelSelect;
	public GameObject[] txt_locked_arena;
	public TextMeshPro txt_NewGame;
	public string[] string_newGameText;
	public GameObject warningCPU;
	public TextMeshPro txt_CPU;
	public TextMeshProUGUI[] txt_ProfileNumber;
	public TextMeshProUGUI[] txt_ProfileDate;
	public Image[] img_ProfileScene;
	public Image[] img_activeProfile;
	public GameObject[] info_updates;
	public TextMeshProUGUI txt_updateNumber;
	public Sprite[] sprite_Scenes;
	public bool demoMode;
	public GameObject window_Sandbox;
	public string scene_arena;
	public string zombie_warehouse;
	public GameObject locked_MuseumBasement;
}
