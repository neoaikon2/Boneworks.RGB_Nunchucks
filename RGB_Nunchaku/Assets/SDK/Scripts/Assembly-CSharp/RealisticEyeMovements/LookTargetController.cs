using UnityEngine;
using UnityEngine.Events;

namespace RealisticEyeMovements
{
	public class LookTargetController : MonoBehaviour
	{
		public Transform[] pointsOfInterest;
		public float lookAtPlayerRatio;
		public float stareBackFactor;
		public float noticePlayerDistance;
		public float personalSpaceDistance;
		public float minLookTime;
		public float maxLookTime;
		public Transform thirdPersonPlayerEyeCenter;
		public bool keepTargetEvenWhenLost;
		public UnityEvent OnStartLookingAtPlayer;
		public UnityEvent OnStopLookingAtPlayer;
		public UnityEvent OnPlayerEntersPersonalSpace;
		public UnityEvent OnLookAwayFromShyness;
	}
}
