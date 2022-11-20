using System;
using UnityEngine;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	public class Spline
	{
		public AnimationCurve curve;
		[SerializeField]
		private bool m_Loop;
		[SerializeField]
		private float m_ZeroValue;
		[SerializeField]
		private float m_Range;
	}
}
