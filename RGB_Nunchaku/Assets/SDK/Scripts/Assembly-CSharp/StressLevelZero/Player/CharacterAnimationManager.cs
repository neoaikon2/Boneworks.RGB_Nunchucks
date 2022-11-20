using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.Player
{
	public class CharacterAnimationManager : MonoBehaviour
	{
		public Transform leftHandTransform;
		public Transform leftHandleTransform;
		public Transform rightHandTransform;
		public Transform rightHandleTransform;
		public Transform leftOpenHandTransform;
		public Transform leftClosedHandTransform;
		public Transform rightOpenHandTransform;
		public Transform rightClosedHandTransform;
		public HandPoseHandleData data;
		public Animator animator;
	}
}
