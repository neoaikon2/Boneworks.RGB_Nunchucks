using UnityEngine;
using System;
using UnityEngine.Events;

namespace PuppetMasta
{
	public class BehaviourBase : MonoBehaviour
	{
		[Serializable]
		public class TargetableAnimatorEvent
		{
			public enum TargetedLimb
			{
				LeftArm = 0,
				RightArm = 1,
				LeftLeg = 2,
				RightLeg = 3,
			}

			public string animationState;
			public float crossfadeTime;
			public int layer;
			public float clipLength;
			public Vector3 localContactPoint;
			public float startIkNormalTime;
			public float contactPointNormalTime;
			public TargetedLimb targetedLimb;
			public float limbStrengthMultiplier;
			public float spineStrengthMultiplier;
		}

		[Serializable]
		public class AnimatorEvent
		{
			public string animationState;
			public float crossfadeTime;
			public int layer;
			public bool resetNormalizedTime;
		}

		[Serializable]
		public struct PuppetEvent
		{
			public string switchToBehaviour;
			public BehaviourBase.AnimatorEvent[] animations;
			public UnityEvent unityEvent;
		}

		public PuppetMaster puppetMaster;
		public bool deactivated;
	}
}
