using UnityEngine;

public class NPCController : MonoBehaviour
{
	public Transform m_playerAgent;
	public Transform orthagonalPlane;
	[SerializeField]
	private float m_totalWaitTime;
	public float visionAngle;
	public float maxSeeDistance;
	public float NormalStoppingDistance;
	public float PursueStoppingDistance;
}
