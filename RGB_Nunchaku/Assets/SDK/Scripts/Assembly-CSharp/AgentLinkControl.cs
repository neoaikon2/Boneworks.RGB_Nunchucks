using UnityEngine;
using UnityEngine.AI;

public class AgentLinkControl : MonoBehaviour
{
	[SerializeField]
	private NavMeshAgent agent;
	public Rigidbody headRB;
	[SerializeField]
	private Rigidbody chestRB;
	[SerializeField]
	private Rigidbody leftElbowRB;
	[SerializeField]
	private Rigidbody rightElbowRB;
	[SerializeField]
	private Rigidbody leftHandRB;
	[SerializeField]
	private Rigidbody rightHandRB;
	[SerializeField]
	private Rigidbody leftKneeRB;
	[SerializeField]
	private Rigidbody rightKneeRB;
	[SerializeField]
	private Rigidbody leftFootRB;
	[SerializeField]
	private Rigidbody rightFootRB;
	[SerializeField]
	private Object owner;
	[SerializeField]
	private NavMeshLink currLink;
	[SerializeField]
	private LinkData currLinkData;
	[SerializeField]
	private LinkData prevFailedLink;
	[SerializeField]
	private bool isOnLink;
	[SerializeField]
	private bool isWaiting;
	[SerializeField]
	private bool isLinking;
	[SerializeField]
	private bool isSearching;
	[SerializeField]
	private bool isCheckingObstruction;
	[SerializeField]
	private bool fallChecking;
	[SerializeField]
	private bool isZipping;
	[SerializeField]
	private ConfigurableJoint headJoint;
	[SerializeField]
	private ConfigurableJoint chestJoint;
	[SerializeField]
	private ConfigurableJoint leftElbowJoint;
	[SerializeField]
	private ConfigurableJoint rightElbowJoint;
	[SerializeField]
	private ConfigurableJoint leftHandJoint;
	[SerializeField]
	private ConfigurableJoint rightHandJoint;
	[SerializeField]
	private ConfigurableJoint leftKneeJoint;
	[SerializeField]
	private ConfigurableJoint rightKneeJoint;
	[SerializeField]
	private ConfigurableJoint leftFootJoint;
	[SerializeField]
	private ConfigurableJoint rightFootJoint;
	[SerializeField]
	private float searchTimer;
	[SerializeField]
	private float standUpTimer;
	[SerializeField]
	private float fallTimer;
	[SerializeField]
	private int failedLink;
	[SerializeField]
	private int passedLink;
	[SerializeField]
	private float successLinkRate;
	public Rigidbody zipGripBody;
	[SerializeField]
	private GameObject crawlJointObj;
	[SerializeField]
	private Shader lineShader;
	[SerializeField]
	private float yDiff;
	[SerializeField]
	private float sqrPos;
}
