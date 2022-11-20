using StressLevelZero.Interaction;
using UnityEngine;

public class PropFlashlight : CylinderGrip
{
	public GameObject LightStuff;
	public AudioSource src_Audio;
	public AudioClip clip_downClick;
	public AudioClip clip_upClick;
	public bool lightOn;
}
