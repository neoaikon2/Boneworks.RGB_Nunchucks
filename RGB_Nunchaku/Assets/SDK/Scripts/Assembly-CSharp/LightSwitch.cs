using UnityEngine;

public class LightSwitch : MonoBehaviour
{
	public GameObject[] Lights;
	public ReflectionProbe[] ReflectionProbes;
	public Renderer[] EmissiveObjects;
	public string PlayerHeadTag;
	public bool LightsON;
	public KeyCode SwithButton;
	public GameObject TextPrefab;
	public string AnimName;
	public AudioClip SwitchSound;
	public float Volume;
}
