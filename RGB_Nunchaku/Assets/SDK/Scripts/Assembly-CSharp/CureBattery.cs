using UnityEngine;
using StressLevelZero.Interaction;
using VLB;

public class CureBattery : MonoBehaviour
{
	[SerializeField]
	private Grip[] _grips;
	[SerializeField]
	private bool wasGrabbed;
	[SerializeField]
	private VolumetricLightBeam lightBeam;
}
