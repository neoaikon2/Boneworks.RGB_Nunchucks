using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.VFX
{
	public class GenericTimer : MonoBehaviour
	{
		private enum TimeType
		{
			Realtime = 0,
			ScaledTime = 1,
		}

		[SerializeField]
		private TimeType CountingType;
		[SerializeField]
		private float Timer;
		[SerializeField]
		private UnityEvent TimerUp;
	}
}
