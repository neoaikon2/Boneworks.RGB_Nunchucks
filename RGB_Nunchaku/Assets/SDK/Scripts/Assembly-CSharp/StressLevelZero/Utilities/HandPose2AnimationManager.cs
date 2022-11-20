using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.Utilities
{
	public class HandPose2AnimationManager : MonoBehaviour
	{
		public AnimationGroup[] animationGroups;
		public Transform leftHandTransform;
		public Transform leftHandleTransform;
		public Transform rightHandTransform;
		public Transform rightHandleTransform;
		public Transform leftOpenHandTransform;
		public Transform leftClosedHandTransform;
		public Transform rightOpenHandTransform;
		public Transform rightClosedHandTransform;
		public Transform Lthumb1;
		public Transform Lthumb2;
		public Transform Lthumb3;
		public Transform Lindex1;
		public Transform Lindex2;
		public Transform Lindex3;
		public Transform Lmiddle1;
		public Transform Lmiddle2;
		public Transform Lmiddle3;
		public Transform Lring1;
		public Transform Lring2;
		public Transform Lring3;
		public Transform Lpinky1;
		public Transform Lpinky2;
		public Transform Lpinky3;
		public Transform Lgrip;
		public Transform Rthumb1;
		public Transform Rthumb2;
		public Transform Rthumb3;
		public Transform Rindex1;
		public Transform Rindex2;
		public Transform Rindex3;
		public Transform Rmiddle1;
		public Transform Rmiddle2;
		public Transform Rmiddle3;
		public Transform Rring1;
		public Transform Rring2;
		public Transform Rring3;
		public Transform Rpinky1;
		public Transform Rpinky2;
		public Transform Rpinky3;
		public Transform Rgrip;
		public HandPoseHandleData data;
		public Animation myAnimation;
		public Animator animator;
	}
}
