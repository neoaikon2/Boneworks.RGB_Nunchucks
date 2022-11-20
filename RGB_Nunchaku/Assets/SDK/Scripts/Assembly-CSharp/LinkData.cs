using UnityEngine;
using System.Collections.Generic;
using StressLevelZero.Props;
using UnityEngine.AI;
using StressLevelZero.AI;

public class LinkData : MonoBehaviour
{
	public enum LinkType
	{
		WINDOW = 0,
		CLIMB = 1,
		DOOR = 2,
		JUMP = 3,
		SUPER_CLIMB = 4,
		WALL = 5,
		ELEVATOR = 6,
		ZIP = 7,
		ZIP_JUMP = 8,
	}

	public LinkType linkType;
	public bool isOccupied;
	public bool isObstructed;
	public bool forceFallen;
	public Transform jumpTarget;
	[SerializeField]
	private List<ObjectDestructable> destList;
	public AgentLinkControl agentControl;
	[SerializeField]
	private NavMeshLink navLink;
	public ConfigurableJoint joint;
	[SerializeField]
	public TriggerRefProxy playerProxy;
	[SerializeField]
	private ObjectDestructable _initialDest;
	public Transform leftHandAttach;
	public Transform rightHandAttach;
	public Transform headAttach;
	public Transform headDownGoal;
	public Transform chestAttach;
	public ConfigurableJoint headJoint;
	public ConfigurableJoint chestJoint;
	public ConfigurableJoint leftHandJoint;
	public ConfigurableJoint rightHandJoint;
	public ConfigurableJoint leftElbowJoint;
	public ConfigurableJoint rightElbowJoint;
	public ConfigurableJoint leftFootJoint;
	public ConfigurableJoint rightFootJoint;
	public ConfigurableJoint leftKneeJoint;
	public ConfigurableJoint rightKneeJoint;
	public GrabbyElevator elevator;
	public Transform zipSpawn;
	public GameObject zipStickPrefab;
	public float zipTime;
	public float zipForce;
	public float crabJumpForce;
	public int destCount;
}
