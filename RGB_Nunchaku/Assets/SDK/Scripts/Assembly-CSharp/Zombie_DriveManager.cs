using UnityEngine;

public class Zombie_DriveManager : MonoBehaviour
{
	public bool isDebugging;
	public Transform m_playerAgent;
	public float ZombiePlayerChaseSpeed;
	public float ZombieWalkSpeed;
	public float NormalStoppingDistance;
	public float PursueStoppingDistance;
	public float extraRotationSpeed;
	[SerializeField]
	private float m_totalWaitTime;
	public float visionAngle;
	public float maxSeeDistance;
	public bool isAttacking;
	public bool isOperating;
	public bool canRessurect;
	public bool canBleedOut;
	public bool canHealUp;
	public bool canHive;
}
