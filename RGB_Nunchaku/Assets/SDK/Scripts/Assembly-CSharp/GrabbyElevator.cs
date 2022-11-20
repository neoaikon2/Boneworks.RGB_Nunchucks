using UnityEngine;
using StressLevelZero.Interaction;

public class GrabbyElevator : MonoBehaviour
{
	[SerializeField]
	private ConfigurableJoint joint;
	[SerializeField]
	private Vector3 topTarget;
	[SerializeField]
	private Vector3 bottomTarget;
	public bool isUp;
	[SerializeField]
	private GameObject hoverObj;
	public float duration;
	[SerializeField]
	private LineRenderer lineRend;
	[SerializeField]
	private Grip _grip;
	public Rigidbody gripBody;
	[SerializeField]
	private ElectricInteractionVolume eVolume;
}
