using System;
using UnityEngine;

namespace UnitySA.Utility
{
	[Serializable]
	public class FOVZoom
	{
		public Camera Camera;
		public float originalFov;
		public float FOVIncrease;
		public float TimeToIncrease;
		public float TimeToDecrease;
		public AnimationCurve IncreaseCurve;
	}
}
