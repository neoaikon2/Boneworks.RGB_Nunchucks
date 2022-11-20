using UnityEngine;
using UnityEngine.Video;
using StressLevelZero.Rig;
using StressLevelZero.Data;

public class GameControl_EmptyGround : MonoBehaviour
{
	public ConfigurableJoint jpz_Valve;
	public ConfigurableJoint jpz_DumbWaiter;
	public ConfigurableJoint jpz_PlatHigh;
	public ConfigurableJoint jpz_PlatLow;
	public bool can_pzl_Valve;
	public ConfigurableJoint jpz_Balloon;
	public VideoPlayer vidPlayer;
	public bool solved_CagePuzzle;
	public DoorControl ctrl_CageDoor;
	public TriggerSwitch[] toggler_SetLights;
	public int count_SolveToggles;
	public GameObject obj_newCage;
	public GameObject obj_Light_Title;
	public GameObject obj_Light_Center;
	public GameObject obj_Light_Complex;
	public GameObject obj_Light_Warning;
	public GameObject obj_Flashlight;
	public GameObject obj_FXParticleStars;
	public GameObject obj_BlockWall;
	public RigManager rm_player;
	public Transform recurPoint;
	public SpawnableObject spawnable_handgunBoxModule;
	public GameObject[] obj_firstRecursion;
	public GameObject[] obj_secondRecursion;
	public GameObject[] obj_thirdRecursion;
}
