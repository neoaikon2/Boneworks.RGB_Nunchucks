using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourHovercraft : BehaviourBase
	{
		public SubBehaviourSensors sensors;
		public SubBehaviourHealth health;
		public SubBehaviourSfx sfx;
		public bool isDespawnOnDeath;
		public float turnRate;
		public float maxBankAngle;
		public float bankResponsiveness;
		public AudioSource skidSource;
	}
}
