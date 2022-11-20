using UnityEngine;

namespace PuppetMasta
{
	public class MuscleCollisionBroadcasterSensor : MuscleCollisionBroadcaster
	{
		public bool isGrounded;
		public Vector3 groundNormal;
		public Vector3 _totalImpulse;
		public float totalMass;
		public float additionalMass;
	}
}
