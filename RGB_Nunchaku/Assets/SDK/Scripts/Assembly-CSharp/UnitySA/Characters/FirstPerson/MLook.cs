using System;

namespace UnitySA.Characters.FirstPerson
{
	[Serializable]
	public class MLook
	{
		public float XSensitivity;
		public float YSensitivity;
		public bool clampVerticalRotation;
		public float MinimumX;
		public float MaximumX;
		public bool smooth;
		public float smoothTime;
		public bool lockCursor;
	}
}
