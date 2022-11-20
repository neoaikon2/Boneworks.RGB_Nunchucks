using UnityEngine;
using StressLevelZero;

public class Control_PowerLever : OnOffSwitch
{
	public bool operation_Float;
	public bool operation_Momentary;
	public int intSubdivisions;
	public float force_Spring;
	public float force_Damper;
	public float force_Max;
	public AudioClip clip_clickOn;
	public AudioClip clip_clickOff;
	public ConfigurableJoint jnt_lever;
	public Haptor hnd_Haptor;
	public GameObject[] indicateOn;
	public GameObject[] indicateOff;
	public SaveItem saveItem;
	public GameObject[] send_Objects;
	[SerializeField]
	private float m_lowerLeverLimit;
	[SerializeField]
	private float m_higherLeverLimit;
	public bool canHaptic;
}
