using System;
using UnityEngine;
using StressLevelZero.AI;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourSensors : SubBehaviourBase
	{
		public LayerMask blockVisionRaycast;
		public float visionFov;
		public float hearingSensitivity;
		public MuscleCollisionBroadcasterSensor[] forceSensorsFeet;
		public MuscleCollisionBroadcasterSensor[] forceSensorsHands;
		public MuscleCollisionBroadcasterSensor[] forceSensorsBody;
		public float additionalMass;
		public float footSupported;
		public float handSupported;
		public float bodySupported;
		public TriggerRefProxy target;
		public TriggerRefProxy selfTrp;
	}
}
