using UnityEngine;
using StressLevelZero.Props.Weapons;

namespace PuppetMasta
{
	public class BehaviourOmniwheel : BehaviourBaseNav
	{
		public enum CombatType
		{
			Charge = 1,
			JumpAttack = 2,
			ThrowLob = 4,
			GunFight = 8,
		}

		public enum EngagedMode
		{
			Follow = 0,
			Stay = 1,
			Hide = 2,
		}

		public float scaleFactor;
		public bool hasCombatProjection;
		public Animator projectionAnimator;
		public Transform hipsProjTransform;
		public Transform chestProjTransform;
		public Transform headProjTransform;
		public Transform gunPropTransform;
		public AnimationCurve deathFlicker;
		public CombatType combatProficiency;
		public CombatType agroState;
		public float chargePrepSpeed;
		public float chargeAttackSpeed;
		public float chargeWindupDistance;
		public float chargeCooldown;
		public Gun gun;
		public float meleeRange;
		public float desiredMeleeDistance;
		public float meleeCooldown;
		public bool enableJumpAttack;
		public float wheelRadius;
		public float restingActivateRange;
		public float jumpCooldown;
		public float jumpCharge;
		public EngagedMode engagedMode;
		public float followDistance;
		public float followSpeed;
		public float breakFollowTargetDistance;
		public float breakFollowHomeDistance;
		public float hideDistance;
		public float hideSpeed;
		public float breakHideTargetDistance;
		public float breakHideHomeDistance;
	}
}
