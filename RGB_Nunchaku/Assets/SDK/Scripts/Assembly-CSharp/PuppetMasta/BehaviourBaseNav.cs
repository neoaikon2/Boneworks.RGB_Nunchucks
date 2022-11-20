using UnityEngine;
using StressLevelZero.AI;
using StressLevelZero.Zones;
using StressLevelZero.Interaction;

namespace PuppetMasta
{
	public class BehaviourBaseNav : BehaviourBase
	{
		public enum MentalState
		{
			Rest = 0,
			Roam = 1,
			Investigate = 2,
			Agroed = 3,
			Engaged = 4,
			MindControlled = 5,
		}

		public enum LocoState
		{
			Standing = 0,
			Walking = 1,
			Fallen = 2,
			GetUp = 3,
			Jumping = 4,
			InAir = 5,
			Grappling = 6,
		}

		public BaseEnemyConfig baseConfig;
		[SerializeField]
		protected BaseEnemyConfig defaultConfig;
		public float restingRange;
		public bool freezeWhileResting;
		public bool homeIsPost;
		public float activeRange;
		public float roamSpeed;
		public Vector2 roamRange;
		public float roamAngSpeed;
		public float roamFrequency;
		public bool roamWanders;
		public float investigateRange;
		public TriggerRefProxy.NpcType agroOnNpcType;
		public float breakAgroTargetDistance;
		public float breakAgroHomeDistance;
		public float agroedSpeed;
		public float agroedAngSpeed;
		public LayerMask meleeAttackMask;
		public bool enableThrowAttack;
		public float throwMaxRange;
		public float throwMinRange;
		public float throwCooldown;
		public float throwVelocity;
		public float gunRange;
		public float gunCooldown;
		public float accuracy;
		public float reloadTime;
		public int clipSize;
		public int burstSize;
		public float desiredGunDistance;
		public Color baseColor;
		public Color agroColor;
		public Renderer[] emissionRenderers;
		public bool isSoundAggroWhenInSecondaryZone;
		public MentalState mentalState;
		public LocoState locoState;
		public float aiTickFreq;
		[SerializeField]
		protected Transform eyeTran;
		public SubBehaviourSensors sensors;
		public SubBehaviourSfx sfx;
		public SubBehaviourHealth health;
		public ZoneTracker zoneTracker;
		public Vector3 homePosition;
		public InteractableHostManager hostManager;
	}
}
