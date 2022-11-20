using UnityEngine;

namespace Chronos
{
	public class Timeline : TimelineEffector
	{
		[SerializeField]
		private TimelineMode _mode;
		[SerializeField]
		private string _globalClockKey;
		[SerializeField]
		private bool _rewindable;
		[SerializeField]
		private float _recordingDuration;
	}
}
