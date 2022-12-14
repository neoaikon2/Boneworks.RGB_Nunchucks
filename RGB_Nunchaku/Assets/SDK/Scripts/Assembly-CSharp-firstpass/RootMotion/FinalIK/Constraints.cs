using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class Constraints
	{
		public Transform transform;
		public Transform target;
		public Vector3 positionOffset;
		public Vector3 position;
		public float positionWeight;
		public Vector3 rotationOffset;
		public Vector3 rotation;
		public float rotationWeight;
	}
}
