using System;
using UnityEngine.Events;

namespace StressLevelZero.Player
{
	[Serializable]
	public class FarEvents
	{
		public UnityEvent OnFarHandHoverBeginEvent;
		public UnityEvent OnFarHandHoverEndEvent;
		public UnityEvent OnFarHandHoverUpdateEvent;
	}
}
