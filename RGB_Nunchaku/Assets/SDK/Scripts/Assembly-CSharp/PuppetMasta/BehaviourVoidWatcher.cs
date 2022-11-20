using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourVoidWatcher : BehaviourBase
	{
		public enum VoidWatcherState
		{
			Emerge = 0,
			Watch = 1,
			Submerge = 2,
		}

		public SubBehaviourSfx sfx;
		public VoidWatcherState watcherState;
		public float emergeTime;
		public float submergeTime;
		public Vector3 emergeLocalDisplace;
		public bool playAgroSound;
		public float loopVolume;
	}
}
