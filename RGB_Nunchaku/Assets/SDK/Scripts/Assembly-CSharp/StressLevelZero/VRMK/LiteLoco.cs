using UnityEngine;
using System;
using StressLevelZero.SFX;

namespace StressLevelZero.VRMK
{
	public class LiteLoco : MonoBehaviour
	{
		[Serializable]
		public class Gear
		{
			public float upshiftVel;
			public float downshiftVel;
			public float stepProgressThreshold;
			public float stepfromtoWeight;
			public float minStepThreshold;
			public AnimationCurve StepRateVCurve;
			public AnimationCurve stepHeight;
			public AnimationCurve StepZInterp;
			public AnimationCurve StepAnkleBend;
			public AnimationCurve MuscleUsage;
		}

		[Serializable]
		public class Grounder
		{
			public LayerMask layers;
			public float maxStep;
			public float footSpeed;
		}

		[Serializable]
		public class Footstep
		{
			public Transform hip;
			public Transform foot;
			public Transform neutralTarget;
			public float rotationOffset;
			public Collider footCollider;
			public PhysicMaterial liftedMat;
			public FootstepSFX stepSfx;
		}

		[Serializable]
		public class StepGroup
		{
			public Transform pelvis;
			public int sisterStepGroup;
			public float legLength;
			public AnimationCurve FootXVCurve;
			[SerializeField]
			private int _gear;
			public bool computeAnimCycle;
			public bool visualizeAnimCycle;
			public float animCycle;
			public LiteLoco.Gear[] gears;
			public LiteLoco.Grounder grounder;
			public LiteLoco.Footstep[] footsteps;
		}

		public float weight;
		public Transform root;
		public Transform neutralRoot;
		public StepGroup[] stepGroups;
	}
}
