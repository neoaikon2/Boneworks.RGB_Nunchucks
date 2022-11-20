using StressLevelZero.Props.Weapons;
using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.Interaction
{
	public class SlideGrip : TargetGrip
	{
		public Gun gun;
		public bool isManualSlideMovement;
		public float slideDistance;
		public Vector3 slideDirection;
		public Vector3 upDirection;
		public HandPose flippedHandPose;
		public bool isFlippable;
	}
}
