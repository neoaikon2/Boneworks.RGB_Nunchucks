using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.VFX
{
	public class TriggeredEmissive : MonoBehaviour
	{
		public Color startColor;
		public Color endColor;
		public Renderer ren;
		public CurveData curve;
		public float blendTime;
	}
}
