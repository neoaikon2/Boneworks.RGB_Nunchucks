using System;
using UnityEngine;

namespace RealisticEyeMovements
{
	[Serializable]
	public class EyeRotationLimiter
	{
		[SerializeField]
		private Transform transform;
		[SerializeField]
		private Quaternion defaultQ;
		[SerializeField]
		private Quaternion lookUpQ;
		[SerializeField]
		private Quaternion lookDownQ;
		public float maxUpAngle;
		public float maxDownAngle;
		[SerializeField]
		private bool isLookUpSet;
		[SerializeField]
		private bool isLookDownSet;
	}
}
