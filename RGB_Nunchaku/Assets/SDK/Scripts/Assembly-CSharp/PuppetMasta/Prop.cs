using UnityEngine;

namespace PuppetMasta
{
	public class Prop : MonoBehaviour
	{
		public int propType;
		public ConfigurableJoint muscle;
		public Muscle.Props muscleProps;
		public bool forceLayers;
		public ConfigurableJoint additionalPin;
		public Transform additionalPinTarget;
		public float additionalPinWeight;
	}
}
