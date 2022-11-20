using UnityEngine;
using VLB;
using Boneworks;
using TMPro;

public class CustomLightMachine : MonoBehaviour
{
	public GameObject obj_Light;
	public Light light;
	public VolumetricLightBeam lightBeam;
	public AlwaysLookAt alwaysLook_light;
	public bool light_onOff;
	public int cur_target;
	public Transform[] targets;
	public string[] string_targets;
	public int cur_location;
	public Transform[] locations;
	public Color32[] colors;
	public string[] string_color;
	public TextMeshPro txt_onOff;
	public TextMeshPro txt_target;
	public TextMeshPro txt_color;
}
