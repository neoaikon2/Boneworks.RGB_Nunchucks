using System;
using VLB.Samples;
using UnityEngine;

namespace StressLevelZero
{
	public class RigScreenOptions : ScreenOptions
	{
		[Serializable]
		public class Options
		{
			public enum GoproLocation
			{
				LEFTEYE = 0,
				CENTEREYE = 1,
				RIGHTEYE = 2,
			}

			public bool showDebugLines;
			public int version;
		}

		public float tiltAngle;
		public Options.GoproLocation loc_GoPro;
		public FreeCameraController cam;
		[SerializeField]
		private Player_Health playerHealth;
	}
}
