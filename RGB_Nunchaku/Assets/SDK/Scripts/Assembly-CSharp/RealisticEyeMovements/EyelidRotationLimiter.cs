using System;
using UnityEngine;

namespace RealisticEyeMovements
{
	[Serializable]
	public class EyelidRotationLimiter
	{
		[SerializeField]
		private Transform transform;
		[SerializeField]
		private Quaternion defaultQ;
		[SerializeField]
		private Quaternion closedQ;
		[SerializeField]
		private Quaternion lookUpQ;
		[SerializeField]
		private Quaternion lookDownQ;
		[SerializeField]
		private float eyeMaxDownAngle;
		[SerializeField]
		private float eyeMaxUpAngle;
		[SerializeField]
		private Vector3 defaultPos;
		[SerializeField]
		private Vector3 closedPos;
		[SerializeField]
		private Vector3 lookUpPos;
		[SerializeField]
		private Vector3 lookDownPos;
		[SerializeField]
		private bool isLookUpSet;
		[SerializeField]
		private bool isLookDownSet;
		[SerializeField]
		private bool isDefaultPosSet;
		[SerializeField]
		private bool isClosedPosSet;
		[SerializeField]
		private bool isLookUpPosSet;
		[SerializeField]
		private bool isLookDownPosSet;
	}
}
