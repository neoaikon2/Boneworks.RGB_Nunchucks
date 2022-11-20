using System;
using UnityEngine;

namespace StressLevelZero.Player
{
	[Serializable]
	public class ControllerInfo
	{
		public enum Type
		{
			UNDEFINED = -1,
			OCCULUS_TOUCH = 0,
			KNUCKLES = 1,
			VIVE_WANDS = 2,
			HOLOGRAPHIC = 3,
		}

		public Type type;
		public Vector3 palmPosition;
		public Quaternion palmRotation;
		public Quaternion wristRotation;
		public Vector3 wristDirection;
	}
}
