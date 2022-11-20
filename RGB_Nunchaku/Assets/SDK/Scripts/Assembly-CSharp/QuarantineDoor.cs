using UnityEngine;

public class QuarantineDoor : MonoBehaviour
{
	[SerializeField]
	private bool openOnStart;
	[SerializeField]
	private ConfigurableJoint joint;
	[SerializeField]
	private bool isClosed;
	[SerializeField]
	private bool isMoving;
	[SerializeField]
	private float dist;
}
