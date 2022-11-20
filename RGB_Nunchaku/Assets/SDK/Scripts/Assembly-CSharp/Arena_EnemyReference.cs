using UnityEngine;
using StressLevelZero.Arena;
using StressLevelZero.AI;
using PuppetMasta;
using StressLevelZero.Combat;
using System.Collections.Generic;

public class Arena_EnemyReference : MonoBehaviour
{
	public enum EnemyType
	{
		CRABLET = 0,
		FRIENDLY_FORD = 1,
		NULL_BODY = 2,
		ZOMBIE = 3,
		OMNI = 4,
		ZOMBIE_THROWER = 5,
		CRABLET_PLUS = 6,
		ENEMY_FORD = 7,
	}

	public enum EnemyState
	{
		POOLED = 0,
		ALIVE = 1,
		DEAD = 2,
	}

	public EnemyType enemyType;
	public EnemyState enemyState;
	public bool isEnemy;
	public bool isFriendly;
	public bool isProtectKing;
	public bool visDebug;
	public bool isCloning;
	public bool isRegistered;
	public GameObject hatObject;
	public Joint hatJoint;
	public EnemyProfile.EntranceType entranceType;
	public TriggerRefProxy agroTarget;
	public PuppetMaster puppet;
	public Rigidbody body;
	public VisualDamageReceiver[] visDamageReceivers;
	public BehaviourPowerLegs legBehaviour;
	public BehaviourCrablet crabBehaviour;
	public BehaviourOmniwheel omniBehaviour;
	public TriggerRefProxy triggerRefProxy;
	public AIBrain aiManager;
	public List<ProjectileBalloon_Arena> enemyBalloonList;
	public AgentLinkControl agentLinkControl;
	[SerializeField]
	private bool outsideArenaBounds;
	[SerializeField]
	private float entranceTimer;
}
