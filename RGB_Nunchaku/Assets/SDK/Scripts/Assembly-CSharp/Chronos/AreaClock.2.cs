using UnityEngine;

namespace Chronos
{
	public class AreaClock<TCollider, TVector> : Clock
	{
		[SerializeField]
		private AreaClockMode _mode;
		[SerializeField]
		private AnimationCurve _curve;
		[SerializeField]
		private TVector _center;
		[SerializeField]
		private float _padding;
		[SerializeField]
		private ClockBlend _innerBlend;
	}
}
