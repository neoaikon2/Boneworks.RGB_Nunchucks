using UnityEngine;

namespace StressLevelZero.Combat
{
	public class Powerable_DamageVolume : Powerable
	{
		public float tickFrequency;
		public float damage;
		public bool damageOnEnter;
		public bool oneTimeDamage;
		public AttackType damageType;
		public Transform damageSourceTransform;
		public float effectiveDistance;
		public float map_low;
		public float map_high;
		public ConfigurableJoint jnt_this;
		public ParticleSystem particles;
		public float particles_low;
		public float particles_high;
		public bool staticVelocityDamage;
		public bool invertVelocity;
		public Rigidbody assosiatedRb;
		public float velocityMinimum;
		public float velocityMaximum;
		public bool scaleDamageWithDistance;
		public float distanceMinimum;
		public float distanceMaximum;
	}
}
