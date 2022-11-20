using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.Interaction
{
	public class Grip : MonoBehaviour
	{
		public enum VirtualControllerModes
		{
			GENERIC = 0,
			HANDGUN = 1,
			RIFLE = 2,
			SLIDE = 3,
			SLIDELOOK = 4,
		}

		public enum Type
		{
			OVERRIDE = 0,
			PRIMARY = 1,
			SECONDARY = 2,
		}

		public VirtualControllerModes virtualControllerMode;
		public Type type;
		public bool isThrowable;
		public Collider[] gripColliders;
		public Collider[] additionalGripColliders;
		public AnimationCurve handleAmplifyCurve;
		public float radius;
		public Transform targetTransform;
		public HandPose handPose;
		[SerializeField]
		public InteractionOptions gripOptions;
		public float priority;
		public float bodyDominance;
		public float minBreakForce;
		public float maxBreakForce;
		public float defaultGripDistance;
		public float gripDistanceSqr;
		public bool orientToHand;
	}
}
