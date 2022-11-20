using System;
using UnityEngine.Events;

namespace StressLevelZero.Player
{
	[Serializable]
	public class NearEvents
	{
		public UnityEvent OnHandHoverBeginEvent;
		public UnityEvent OnHandHoverEndEvent;
		public UnityEvent OnHandHoverUpdateEvent;
	}
}
