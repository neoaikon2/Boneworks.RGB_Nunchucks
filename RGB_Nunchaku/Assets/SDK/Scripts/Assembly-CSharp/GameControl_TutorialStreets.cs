using StressLevelZero.VRMK;
using UnityEngine;
using TMPro;
using StressLevelZero.Interaction;
using UnityEngine.UI;

public class GameControl_TutorialStreets : GameControl
{
	public BodyVitals ctrl_bodyVitals;
	//public Data_Manager dataManager;
	public bool demoMode;
	public AudioSource[] src_Speakers;
	public AudioClip[] clip_Attention;
	public AudioClip[] clip_Reach;
	public AudioClip[] clip_Throw;
	public AudioClip[] clip_Secure;
	public AudioClip[] clip_Battery;
	public AudioClip[] clip_Good;
	public AudioClip[] clip_Movement;
	public AudioClip[] clip_Whenever;
	public string[] string_InfoToDisplay;
	public int int_SequenceStep;
	public TextMeshPro text_MuseumCount;
	public TextMeshPro text_IncinerationCount;
	public TextMeshPro text_ObjectName;
	public TextMeshPro text_AnomalyType;
	public TextMeshPro text_Recommend;
	public GameObject obj_taskDisplay;
	public GameObject img_CoffeeCup;
	public GameObject img_ClipBoard;
	public GameObject img_LightGod;
	public GameObject img_Gammon;
	public GameObject img_Battery;
	public ParticleSystem pfx_warpSpawn;
	public ParticleSystem pfx_warpPedestal;
	public GameObject obj_Cup;
	public CylinderGrip grip_Cup;
	public GameObject obj_ClipBoard;
	public GameObject obj_LightGod;
	public GameObject obj_Gammon;
	public GameObject obj_Battery;
	[SerializeField]
	private InteractableHost batteryHost;
	public Powerable_Joint jnt_RemovalBox;
	public AudioClip clip_Positive;
	public AudioClip clip_Negative;
	public GameObject fx_Confetti;
	public Image img_icon_Loco;
	public Image img_icon_Crouch;
	public Image img_icon_Snap;
	public Image img_icon_Jump;
	public Image img_icon_Menu;
	public Image img_icon_Input;
	public Image img_icon_Time;
	public TextMeshProUGUI txt_CountDown;
	public ValveFog fog;
}
