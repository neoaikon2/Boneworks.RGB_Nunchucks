using System;
using UnityEngine;

namespace Boneworks
{
	[Serializable]
	public struct HandPoseJoint
	{
		public Vector3 localPosition;
		public Quaternion localRotation;
	}
}
