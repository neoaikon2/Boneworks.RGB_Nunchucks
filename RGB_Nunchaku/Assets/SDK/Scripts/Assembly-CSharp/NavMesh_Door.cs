using UnityEngine;
using StressLevelZero.Props;

public class NavMesh_Door : MonoBehaviour
{
	public enum DoorType
	{
		DoorA = 0,
		DoorB = 1,
		DoorC = 2,
		DoorD = 3,
		DoorE = 4,
	}

	[SerializeField]
	private GarageDoor_Phys_Powerable garageDoor;
	public DoorType doorType;
	[SerializeField]
	private GameObject rootDoorObj;
	[SerializeField]
	private ObjectDestructable destructable;
	[SerializeField]
	private bool isDestructable;
	[SerializeField]
	private Powerable_Joint pJoint;
}
