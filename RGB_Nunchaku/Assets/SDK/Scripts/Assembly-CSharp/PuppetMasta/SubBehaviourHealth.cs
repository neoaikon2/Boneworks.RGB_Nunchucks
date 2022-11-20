using System;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourHealth : SubBehaviourBase
	{
		[Serializable]
		public struct UsageSettings
		{
			public float hips;
			public float spine;
			public float legLf;
			public float legRt;
			public float armLf;
			public float armRt;
		}

		public enum StunGroup
		{
			Spine = 0,
			ArmLf = 1,
			ArmRt = 2,
			LegLf = 3,
			LegRt = 4,
			Head = 5,
		}

		public float maxHitPoints;
		public float maxAppendageHp;
		public float stunRecovery;
		public float maxStunSeconds;
		public float minHeadImpact;
		public float minSpineImpact;
		public float minLimbImpact;
		public bool isOrganic;
		public bool stunActive;
		public float bluntMult;
		public float stabMult;
		public float pierceMult;
		public StunGroup[] muscles;
		public float cur_hp;
		public float cur_arm_lf;
		public float cur_arm_rt;
		public float cur_leg_lf;
		public float cur_leg_rt;
		public float stun_spine;
		public float stun_arm_lf;
		public float stun_arm_rt;
		public float stun_leg_lf;
		public float stun_leg_rt;
		public float usage_hips;
		public float usage_spine;
		public float usage_arm_lf;
		public float usage_arm_rt;
		public float usage_leg_lf;
		public float usage_leg_rt;
		public float aggression;
		public float irritability;
		public float placability;
		public float vengefulness;
	}
}
