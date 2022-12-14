using UnityEngine;
using System;
using System.Collections.Generic;
using RootMotion;

namespace PuppetMasta
{
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		public struct StateSettings
		{
			public float killDuration;
			public float deadMuscleWeight;
			public float deadMuscleDamper;
			public float maxFreezeSqrVelocity;
			public bool enableAngularLimitsOnKill;
			public bool enableInternalCollisionsOnKill;
		}

		public enum State
		{
			Alive = 0,
			Dead = 1,
			Frozen = 2,
		}

		public enum Mode
		{
			Active = 0,
			Kinematic = 1,
			Disabled = 2,
		}

		public PuppetMasterHumanoidConfig humanoidConfig;
		public Transform targetRoot;
		public State state;
		public StateSettings stateSettings;
		public Mode mode;
		public float blendTime;
		public bool fixTargetTransforms;
		public int solverIterationCount;
		public bool visualizeTargetAnimation;
		public bool visualizeTargetPose;
		public float mappingWeight;
		public float muscleWeight;
		public float muscleSpring;
		public float muscleDamper;
		public bool updateJointAnchors;
		public bool angularLimits;
		public bool internalCollisions;
		public Muscle[] muscles;
		public List<SolverManager> solvers;
	}
}
