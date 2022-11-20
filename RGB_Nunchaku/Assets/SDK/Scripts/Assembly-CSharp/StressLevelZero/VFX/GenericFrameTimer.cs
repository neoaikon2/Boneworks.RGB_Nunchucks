using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.VFX
{
	public class GenericFrameTimer : MonoBehaviour
	{
		private enum FrameType
		{
			FixedUpdate = 0,
			EndOfFrame = 1,
		}

		[SerializeField]
		private FrameType CountingType;
		[SerializeField]
		private int FramesToCount;
		[SerializeField]
		private UnityEvent TimerUp;
	}
}
