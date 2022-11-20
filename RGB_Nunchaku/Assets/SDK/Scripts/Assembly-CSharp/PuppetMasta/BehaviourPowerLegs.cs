using UnityEngine;
using StressLevelZero.Data;

namespace PuppetMasta
{
	public class BehaviourPowerLegs : BehaviourBaseNav
	{
		public enum CombatType
		{
			WildPunch = 1,
			FistFight = 2,
		}

		public enum EngagedMode
		{
			Mirror = 0,
			Follow = 1,
			Stay = 2,
			Hide = 3,
		}

		public SubBehaviourIk ik;
		public SubBehaviourFaceanim faceAnim;
		public SubBehaviourHandPose handPoser;
		public float scaleFactor;
		public GameObject throwVfx;
		public CombatType combatProficiency;
		public CombatType agroState;
		public float meleeRange;
		public float desiredMeleeDistance;
		public float meleeCooldown;
		public BehaviourBase.TargetableAnimatorEvent WildPunchBigL;
		public BehaviourBase.TargetableAnimatorEvent WildPunchBigR;
		public BehaviourBase.TargetableAnimatorEvent WildPunchJabL;
		public BehaviourBase.TargetableAnimatorEvent WildPunchJabR;
		public BehaviourBase.TargetableAnimatorEvent Fist1PunchL;
		public BehaviourBase.TargetableAnimatorEvent Fist1PunchR;
		public BehaviourBase.TargetableAnimatorEvent Fist1MidUppercutL;
		public BehaviourBase.TargetableAnimatorEvent Fist1MidUppercutR;
		public EnemyPoseData standingIdle;
		public float restingActivateRange;
		public float jumpCooldown;
		public float jumpCharge;
		public bool getUpWhileResting;
		public BehaviourBase.AnimatorEvent[] onGetUpProne;
		public BehaviourBase.AnimatorEvent[] onGetUpSupine;
		public EngagedMode engagedMode;
		public float desiredDistance;
		public bool followPlayer;
		public float engagedSpeed;
		public float breakEngagedTargetDistance;
		public float breakEngagedHomeDistance;
		public float mirrorSkill;
	}
}
