using System;
using UnityEngine;

namespace UnitySA.Utility
{
	[Serializable]
	public class CurveCtrlBob
	{
		public float HorizontalBobRange;
		public float VerticalBobRange;
		public AnimationCurve Bobcurve;
		public float VerticaltoHorizontalRatio;
	}
}
