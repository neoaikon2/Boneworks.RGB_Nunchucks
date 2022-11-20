using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourHead : BehaviourBase
	{
		public enum CrabState
		{
			Rest = 0,
			Meander = 1,
			Roam = 2,
			Investigate = 3,
			Agroed = 4,
			KnockedOut = 5,
			Facehug = 6,
			Headmount = 7,
		}

		public enum LocoState
		{
			Idle = 0,
			Walking = 1,
			Rolling = 2,
			Jumping = 3,
			InAir = 4,
			Headmount = 5,
		}

		public SubBehaviourSensors sensors;
		public SubBehaviourHealth health;
		public SubBehaviourSfx sfx;
		public SubBehaviourFaceanim faceAnim;
		public CrabState crabState;
		public LocoState locoState;
		public Color eyeColor;
		public Color agroColor;
		public Transform eyeTran;
		public Rigidbody targetRb;
		public float aiTickFreq;
		public float targetDistance;
		public float investigateRange;
		public float breakAgroTargetDistance;
		public float breakAgroHomeDistance;
		public float meanderSpeed;
		public float roamSpeed;
		public float agroedSpeed;
		public float jumpCooldown;
		public float jumpCharge;
		public bool enableJumpAttack;
	}
}
