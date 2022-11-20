using UnityEngine;
using System;

namespace PuppetMasta
{
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		public class HumanoidMuscle
		{
			[SerializeField]
			public string name;
			public HumanBodyBones bone;
			public Muscle.Props props;
		}

		public PuppetMaster.State state;
		public PuppetMaster.StateSettings stateSettings;
		public PuppetMaster.Mode mode;
		public float blendTime;
		public bool fixTargetTransforms;
		public int solverIterationCount;
		public bool visualizeTargetPose;
		public float mappingWeight;
		public float muscleWeight;
		public float muscleSpring;
		public float muscleDamper;
		public bool updateJointAnchors;
		public bool angularLimits;
		public bool internalCollisions;
		public HumanoidMuscle[] muscles;
	}
}
