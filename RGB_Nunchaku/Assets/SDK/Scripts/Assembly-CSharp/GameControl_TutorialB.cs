using UnityEngine;
using StressLevelZero.VRMK;
using TMPro;

public class GameControl_TutorialB : MonoBehaviour
{
	public BodyVitals ctrl_bodyVitals;
	public AudioClip clip_PositiveAction;
	public AudioClip clip_NegativeAction;
	public GameObject objectLight;
	public AudioSource[] src_Speakers;
	public AudioClip[] clip_Speakers;
	public TextMeshProUGUI text_InfoDisplay;
	public string[] string_InfoToDisplay;
	public int int_SequenceStep;
	public GameObject hider;
	public GameObject tut_forcegrab;
	public GameObject tut_snapturn;
	public GameObject holo_gate;
	public ConfigurableJoint jnt_gate;
	public Vector3 tar_gateLoc_UP;
	public Vector3 tar_gateLoc_DOWN;
	public AudioSource src_FirstGate;
	public GameObject[] tut_Runner;
	public GameObject obj_Battery;
	public GameObject obj_Cup;
	public GameObject text_CupTask;
	public GameObject text_CupComplete;
	public AudioClip clip_Positive;
	public AudioClip clip_Negative;
	public GameObject fx_Confetti;
}
